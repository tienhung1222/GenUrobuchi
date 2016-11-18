using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(CapsuleCollider))]
    [RequireComponent(typeof(Animator))]

    public class Attack : MonoBehaviour {

        [SerializeField]
        float m_AnimSpeedMultiplier = 1f;

        Rigidbody m_Rigidbody;
        Animator m_Animator;
        CapsuleCollider m_Capsule;
        Vector3 m_CapsuleCenter;
        bool m_Attack;


        void Start()
        {
            m_Animator = GetComponent<Animator>();
            m_Rigidbody = GetComponent<Rigidbody>();
            m_Capsule = GetComponent<CapsuleCollider>();

        }

        
        void Update() {

        }
    }
}
