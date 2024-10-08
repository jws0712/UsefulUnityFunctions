namespace UnityFunctions.FSM.Step3
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class BaseGameEntity : MonoBehaviour
    {
        private static int m_iNextVauildID = 0;

        private int id;
        public int ID
        {
            set
            {
                id = value;
                m_iNextVauildID++;
            }
            get => id;
        }

        private string entityName;
        private string personalColor;

        public virtual void Setup(string name)
        {
            ID = m_iNextVauildID;

            entityName = name;

            int color = Random.Range(0, 1000000);
            personalColor = $"#{color.ToString("x6")}";
        }

        public abstract void Updated();

        public void PrintText(string text)
        {
            Debug.Log($"<color={personalColor}><b>{entityName}</b></color> : {text}");
        }
    }
}

