using UnityEngine;

[CreateAssetMenu(fileName = "New Horse", menuName = "Horse Racing/Horse Data")]
public class HorseData : ScriptableObject
{
    public string horseName;

    [Header("Core Stats")]
    public int health;       // 체력
    public int speed;        // 스피드
    public int stamina;      // 스태미나
    public int breakthrough; // 돌파력
    public int intelligence; // 지능

    [Header("State")]
    public int condition = 100; // 기본 컨디션
    public bool isDead = false; // 사망 여부
}