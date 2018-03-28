using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;
public class BombManager : MonoBehaviour
{
    public GameObject bomb;
    public GUIText bombNumber;
    public GameObject myo = null;
    private Quaternion _antiYaw = Quaternion.identity;
    private Pose _lastPose = Pose.Unknown;


    public int  count;

    public static BombManager _instance;
    void Awake()
    {
        _instance = this;
        bomb.SetActive(false);
        bombNumber.gameObject.SetActive(false);
    }
    void Update()
    {
        ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo>();
        if (thalmicMyo.pose != _lastPose)
        {
            _lastPose = thalmicMyo.pose;

            if (thalmicMyo.pose == Pose.FingersSpread && BombManager._instance.count > 0)
            {
                this.UseABomb();
                //GameObject.Find("bomb").GetComponent<Enemy>().toDie();
                Enemy toDie = GameObject.FindObjectOfType<Enemy>();
                BombManager UseABomb = GameObject.FindObjectOfType<BombManager>();
                ExtendUnlockAndNotifyUserAction(thalmicMyo);
            }
        } 
    }
     
    public void AddAbomb()
    {
        bomb.SetActive(true);
        bombNumber.gameObject.SetActive(true);
        count++;
        bombNumber.text = "X" + count;

    }
    public void UseABomb()
    {   
        if (count > 0)
          {
            this.GetComponent<AudioSource>().Play();
            count--;
            bombNumber.text = "X" + count;
            if (count <= 0)
            {
                bomb.SetActive(false);
                bombNumber.gameObject.SetActive(false);

            }

        }
    }
    void ExtendUnlockAndNotifyUserAction(ThalmicMyo myo)
    {
        ThalmicHub hub = ThalmicHub.instance;

        if (hub.lockingPolicy == LockingPolicy.Standard)
        {
            myo.Unlock(UnlockType.Timed);
        }

        myo.NotifyUserAction();
    }
    
    
       
}
