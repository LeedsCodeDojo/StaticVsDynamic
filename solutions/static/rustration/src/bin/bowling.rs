extern crate rustyline;

use rustyline::Editor;

/// Iterator over frame scores
struct FrameIter<'a> {
    balls: &'a Vec<u16>,
    frame_start: usize,
    frame: usize
}

impl<'a> FrameIter<'a> {

    /// Constructs a new FrameIter borrowing a Vec of individual scores
    pub fn new(balls: &'a Vec<u16>) -> FrameIter {
        FrameIter {
            balls: balls,
            frame_start: 0,
            frame: 0
        }
    }

    /// Checks whether any more frames are available
    fn has_next(&self) -> bool {
       self.frame_start < self.balls.len() && self.frame < 10
    }

    /// Looks ahead n balls, returning 0 if we run out
    fn look_ahead(&self, n: usize) -> u16 {
        *self.balls.get(self.frame_start + n).unwrap_or(&0)
    }
}

impl<'a> Iterator for FrameIter<'a> {
    type Item = u16;

    /// Calculate the next frame score:
    /// return Some(score) if there are frames left or None otherwise
    fn next(&mut self) -> Option<u16> {
        let result;
        if self.has_next() {
            if self.balls[self.frame_start] == 10 {
                result = 10 + self.look_ahead(1) + self.look_ahead(2);
                self.frame_start += 1;
            } else {
                result = match self.balls[self.frame_start] + self.look_ahead(1) {
                    10 => 10 + self.look_ahead(2),
                    x => x,
                };
                self.frame_start += 2;
            }
            self.frame += 1;
            Some(result)
        } else {
            None
        }
    }
}

/// Calculate the score of a whole game
fn score(balls: &Vec<u16>) -> u16 {
    FrameIter::new(balls).sum()
}

fn main() {
    let mut rl = Editor::<()>::new();

    println!("Enter ball scores separated by spaces; <ENTER> when done");
    
    let balls: Vec<u16> = rl.readline("> ").unwrap()
        .split_whitespace()
        .map(|x| x.parse().unwrap())
        .collect();

    let result = score(&balls);

    println!("Input: {:?}", balls);
    println!("Score: {}", result);
}

#[cfg(test)]
mod test {
    use score;

    #[test]
    fn test_one_ball() {
        assert_eq!(score(&vec![3]), 3);
    }

    #[test]
    fn test_two_frames() {
        assert_eq!(score(&vec![3, 5, 2, 4]), 14);
    }

    #[test]
    fn test_two_frames_strike() {
        assert_eq!(score(&vec![10, 2, 1]), 16);
    }

    #[test]
    fn test_two_frames_half() {
        assert_eq!(score(&vec![5, 5, 6, 3]), 25);
    }

    #[test]
    fn test_two_frames_miss_then_half() {
        assert_eq!(score(&vec![0, 10, 2, 1]), 15);
    }

    #[test]
    fn test_two_strikes() {
        assert_eq!(score(&vec![10, 10, 2, 3]), 42);
    }

    #[test]
    fn test_275() {
        assert_eq!(score(&vec![10, 10, 10, 10, 10, 10, 10, 10, 10, 5, 5, 10]), 275);
    }

    #[test]
    fn test_288() {
        assert_eq!(score(&vec![10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 8, 2]), 288);
    }

    #[test]
    fn test_300() {
        assert_eq!(score(&vec![10,10,10,10,10,10,10,10,10,10,10,10]), 300);
    }
}
