using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1. Variable
        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;
        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);

        //2. Grouptype Variable
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel1 = new int[3];
        monsterLevel1[0] = 1;
        monsterLevel1[1] = 6;
        monsterLevel1[2] = 20;
        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsterLevel1[0]);
        Debug.Log(monsterLevel1[1]);
        Debug.Log(monsterLevel1[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        //Debug.Log(items[1]);  에러 발생.

        //3. operating
        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial); //출력: 튜토리얼이 끝난 용사입니까? False

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 && mana <= 20; // && is and operation
        Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

        isBadCondition = health <= 50 || mana <= 20; // || is OR operation
        Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까? " + condition);

        //4.keywords - keywords are predefined, reserved identifiers that have special meanings to the compiler. So keywards can't be used as Variable names.
        //ex) int, float, string and more.

        //5.conditions
        //1)If statements
        if (true)
        {
            Debug.Log("hello");
        }
        else
        {
            Debug.Log("hello in else statement");
        }

        //2)switch statement
        switch (monsters[1])
        {
            case "슬라임":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "사막뱀":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default:
                Debug.Log("There is no monsters.");
                break;
        }

        //6.iteration
        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독 데미지를 입었습니다." + health);
            }
            else
                Debug.Log("사망하였습니다.");
            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
            for (int count = 0; count < 10; count++)
            {
                health++;
                Debug.Log("붕대로 치료 중....." + health);
            }
            //.Length(Array) .Count(List)
            for (int index = 0; index < monsters.Length; index++)
            {
                Debug.Log("이 지역에 있는 몬스터" + monsters[index]);
            }
            //foreach is uesd to find a Char in a string and also it can be used to check whether a certain character is present in a given string.
            foreach (string monster in monsters)
            {
                Debug.Log("이 지역에 있는 몬스터 : " + monster);
            }
        }
        health = Heal(health);

        //8.class
        Actor player = new Actor();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
    }

    //7.function(method)
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다." + currentHealth);
        return currentHealth;
    }
}