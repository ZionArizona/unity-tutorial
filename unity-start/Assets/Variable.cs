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
        string playerName = "���˻�";
        bool isFullLevel = false;
        Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);

        //2. Grouptype Variable
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel1 = new int[3];
        monsterLevel1[0] = 1;
        monsterLevel1[1] = 6;
        monsterLevel1[2] = 20;
        Debug.Log("�ʿ� �����ϴ� ����");
        Debug.Log(monsterLevel1[0]);
        Debug.Log(monsterLevel1[1]);
        Debug.Log(monsterLevel1[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0);

        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        //Debug.Log(items[1]);  ���� �߻�.

        //3. operating
        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);

        string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log(title + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("���� �����Դϱ�?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�? " + isEndTutorial); //���: Ʃ�丮���� ���� ����Դϱ�? False

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 && mana <= 20; // && is and operation
        Debug.Log("����� ���°� ���޴ϱ�? " + isBadCondition);

        isBadCondition = health <= 50 || mana <= 20; // || is OR operation
        Debug.Log("����� ���°� ���޴ϱ�? " + isBadCondition);

        string condition = isBadCondition ? "����" : "����";
        Debug.Log("����� ���°� ���޴ϱ�? " + condition);

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
            case "������":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�縷��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���Ͱ� ����!");
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
                Debug.Log("�� �������� �Ծ����ϴ�." + health);
            }
            else
                Debug.Log("����Ͽ����ϴ�.");
            if (health == 10)
            {
                Debug.Log("�ص����� ����մϴ�.");
                break;
            }
            for (int count = 0; count < 10; count++)
            {
                health++;
                Debug.Log("�ش�� ġ�� ��....." + health);
            }
            //.Length(Array) .Count(List)
            for (int index = 0; index < monsters.Length; index++)
            {
                Debug.Log("�� ������ �ִ� ����" + monsters[index]);
            }
            //foreach is uesd to find a Char in a string and also it can be used to check whether a certain character is present in a given string.
            foreach (string monster in monsters)
            {
                Debug.Log("�� ������ �ִ� ���� : " + monster);
            }
        }
        health = Heal(health);

        //8.class
        Actor player = new Actor();
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + "�Դϴ�.");
    }

    //7.function(method)
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("���� �޾ҽ��ϴ�." + currentHealth);
        return currentHealth;
    }
}