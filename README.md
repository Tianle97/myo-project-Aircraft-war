# myo-project-Aircraft-war
> Module: Gesture UI Development / the 4th Year     
> Lecturer: Damien Costello   
> By: WENXUAN ZHANG / G00329417
## Introduction
This project is completed by UNITY3D engine and Myo Armband. In this game, you can use myo armband to use gestures to control the game, such as controlling the direction, pause the game, restore the game, get the game bomb and use it.

In this game,you can use gesture wave in make aircraft to left,wave out to right,double tap to pause game and use gesture finger-speared to
use bomb.

#### A qiuckly demonstration:

![](https://github.com/neroZWX/myo-project-Aircraft-war/blob/master/demonstration.gif)
## what is myo armband
The Myo armband is a gesture recognition device worn on the forearm and manufactured by Thalmic Labs. The Myo enables the user to control technology wirelessly using various hand motions. It uses a set of electromyographic (EMG) sensors that sense electrical activity in the forearm muscles, combined with a gyroscope, accelerometer and magnetometer to recognize gestures. The Myo can be used to control video games, presentations, music and visual entertainment. It differs from the Leap Motion device as it is worn rather than a 3D array of cameras that sense motion in the environment.
## Purpose of the application 
The purposeof this project is Because Myo armband is a muscle sensory recognition device(It uses a set of electromyographic (EMG) sensors that sense electrical activity in the forearm muscles, combined with a gyroscope, accelerometer and magnetometer to recognize gestures), making a game can better test the sensitivity of myo armband in a comprehensive way.For control games by using myo armband, such as myo armband with your arm moving to the right, then the main character in the game moves to the right.
## Gestures identified as appropriate for this application
The Myo armband recognizes 5 pre-set gestures out of the box. They are:
### double tap
![](https://github.com/neroZWX/myo-project-Aircraft-war/blob/master/images/double-tap.gif)
### finger-spread
![](https://github.com/neroZWX/myo-project-Aircraft-war/blob/master/images/finger-spread.gif)
### wave in 
![](https://github.com/neroZWX/myo-project-Aircraft-war/blob/master/images/wave-in.gif)
### wave out
![](https://github.com/neroZWX/myo-project-Aircraft-war/blob/master/images/wave-out.gif)
### fist
![](https://github.com/neroZWX/myo-project-Aircraft-war/blob/master/images/fist.gif)

In this game,you can use gesture wave in make aircraft to left

wave out to right.

double tap to pause game.

finger-speared to use bomb.

## Hardware used in creating the application
1. Myo-Armbard

 2.Bluetooth connector

 3.A windows Laptop.
## Architecture for the solution
For reference to how to control the main characters of the game, I refer to the official C# game code released by myo.
For example:make game mian character  to left
```c#
if (thalmicMyo.pose == Pose.WaveIn)//If the recognition gestures are wavein then make left

            {

                Hero.Translate(Vector3.left * 0.8f, Space.Self);//define Moving speed
                 ExtendUnlockAndNotifyUserAction(thalmicMyo);
                checkPosition();//mian character moving range

            }
```            
To right:
```c#
if (thalmicMyo.pose == Pose.WaveOut)//If the recognition gestures are waveout then make right

            {

                Hero.Translate(Vector3.right * 0.8f, Space.Self);//define Moving speed
                ExtendUnlockAndNotifyUserAction(thalmicMyo);
                checkPosition();
                }
```                
To pause game:
```c#
if (thalmicMyo.pose == Pose.DoubleTap) {//If the recognition gestures are doubleTap then pause game
                this.GetComponent<AudioSource>().Play();//get pause game voice

                GameManager._instance.transfromGameState();//Convert the game state to pause
                ExtendUnlockAndNotifyUserAction(thalmicMyo);
            }
 ```
 To use bomb:
 ```c#
 if (thalmicMyo.pose == Pose.FingersSpread && BombManager._instance.count > 0)//If the recognition gestures are fingerspread then use bomb
            {
                this.UseABomb();
                //GameObject.Find("bomb").GetComponent<Enemy>().toDie();
                Enemy toDie = GameObject.FindObjectOfType<Enemy>();
                BombManager UseABomb = GameObject.FindObjectOfType<BombManager>();
                ExtendUnlockAndNotifyUserAction(thalmicMyo);
            }
  ```
  
## Class diagram
![](https://github.com/neroZWX/myo-project-Aircraft-war/blob/master/classDigram.PNG)
