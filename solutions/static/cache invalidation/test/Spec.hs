module Main where

import Control.Arrow
import Test.Hspec

main :: IO ()
main = hspec $ do
  describe "scoreFromFrames" $ do
    let shouldScore frames expected = it ("works with " ++ show frames) $ scoreFromFrames frames `shouldBe` expected
    [Frame 3 5] `shouldScore` 8
    [Frame 3 5, Frame 2 4] `shouldScore` 14
    [Frame 10 0, Frame 2 1] `shouldScore` 16
    [Frame 5 5, Frame 6 3] `shouldScore` 25
    [Frame 10 0, Frame 10 0, Frame 10 0, Frame 0 0] `shouldScore` 60
    (replicate 9 (Frame 10 0) ++ [Frame 5 5, Frame 10 0]) `shouldScore` 275
    (replicate 10 (Frame 10 0) ++ [Frame 8 2]) `shouldScore` 288
    (replicate 10 (Frame 10 0) ++ [Frame 10 0, Frame 10 0]) `shouldScore` 300

  describe "framesFromBalls" $ do
    let shouldGive balls expected = it ("works with " ++ show balls) $ framesFromBalls balls `shouldBe` expected
    [] `shouldGive` []
    [3,5] `shouldGive` [Frame 3 5]
    [10] `shouldGive` [Frame 10 0]
    [10,3,5] `shouldGive` [Frame 10 0, Frame 3 5]

  describe "ballsFromString" $ do
    let shouldGive str expected = it ("works with " ++ show str) $ ballsFromString str `shouldBe` expected
    "" `shouldGive` []
    "[3,5]" `shouldGive` [3,5]
    "[10,-] [10,-]" `shouldGive` [10,10]

  describe "testCases" $ do
    let shouldGive str expected = it (show str ++ " gives " ++ show expected) $ calculate str `shouldBe` expected
    "[1,2]" `shouldGive` 3
    "[0,0] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [3,2]" `shouldGive` 21
    "[5,5] [6,2]" `shouldGive` 24
    "[5,5] [0,1]" `shouldGive` 11
    "[5,5] [5,5] [5,5] [5,5] [5,1]" `shouldGive` 66
    "[10,-] [6,3]" `shouldGive` 28
    "[10,-] [0,0] [1,1]" `shouldGive` 12
    "[10,-] [10,-] [10,-] [10,-] [1,1]" `shouldGive` 95
    "[1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [8,2] 5" `shouldGive` 33
    "[1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [10,-] 8 1" `shouldGive` 37
    "[1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [10,-] 10 10" `shouldGive` 48
    "[10,-] [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] 10 10" `shouldGive` 300

data Frame = Frame Int Int deriving (Show, Eq)

data FrameType = Strike | Spare | Rubbish deriving (Show, Eq)

frameType :: Frame -> FrameType
frameType (Frame n m)
  | n     == 10 = Strike
  | n + m == 10 = Spare
  | otherwise   = Rubbish

frameScores :: [Frame] -> [Int]
frameScores frames = map frameScore $ zip3 frames (drop 1 frames) (drop 2 frames)

frameScore :: (Frame, Frame, Frame) -> Int
frameScore (thisFrame@(Frame thisN thisM), nextFrame@(Frame nextN nextM), Frame nextNextN nextNextM)
  = thisN
  + thisM
  + case frameType thisFrame of
          Strike -> nextN
                  + case frameType nextFrame of
                          Strike -> nextNextN
                          _      -> nextM
          Spare  -> nextN
          _      -> 0

scoreFromFrames :: [Frame] -> Int
scoreFromFrames frames = sum (take 10 $ frameScores (frames ++ [Frame 0 0, Frame 0 0]))

framesFromBalls :: [Int] -> [Frame]
framesFromBalls [] = []
framesFromBalls [uniqueBall] = [Frame uniqueBall 0]
framesFromBalls (currBall : nextBall : otherBalls)
  | currBall == 10 = Frame 10 0 : framesFromBalls (nextBall : otherBalls)
  | otherwise      = Frame currBall nextBall : framesFromBalls otherBalls

ballsFromString :: String -> [Int]
ballsFromString = map read . words . map replaceNonDigitWithSpace

replaceNonDigitWithSpace :: Char -> Char
replaceNonDigitWithSpace c
  | '0' <= c && c <= '9' = c
  | otherwise            = ' '

calculate :: String -> Int
calculate = scoreFromFrames . framesFromBalls . ballsFromString
