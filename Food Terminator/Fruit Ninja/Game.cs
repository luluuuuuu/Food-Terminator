using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_Ninja
{
    public class Game
    {
        public Image background;
        public List<Element> elements;
        public string bombType;//不可切的食物类型
        public Label bombLabel;
        public Score currentScore;
        public int bombsClicked;
        public int time;
        public static Random r = new Random();

        //游戏初始化
        public Game(object t)
        {
            bombLabel = (t as Label);

            elements = new List<Element>();
            bombsClicked = 0;
            currentScore = new Score(0,new DateTime(),"");
            time = 60;
            generateType();
            Console.WriteLine(bombType);

            if (SettingsForm.settings.difficulty == "EASY")
            {
                background = Properties.Resources.background;
                bombLabel.Text = "";
            }
            else if (SettingsForm.settings.difficulty == "MEDIUM")
            {
                background = Properties.Resources.background;
                bombLabel.Text = "Don't cut " + bombType + " !!!";
            }
            else if (SettingsForm.settings.difficulty == "HARD")
            {
                background = Properties.Resources.background;
                bombLabel.Text = "Don't cut " + bombType + " !!!";
            }
        }

        //随机生成不可切的食物类型
        public void generateType()
        {
            Random t = new Random();
            int typeID = t.Next(3);
            if (typeID == 0)
                bombType = "Fruit";
            else if (typeID == 1)
                bombType = "Vegetable";
            else
                bombType = "Dessert";
        }

        public void Draw(PaintEventArgs e)
        {
            foreach(Element el in elements)
                el.Draw(e);
        }

        public void MoveElements()
        {
            foreach(Element el in elements)
                el.Move();
            for(int i = elements.Count - 1; i >= 0; i--)
            {
                if (SettingsForm.settings.difficulty == "EASY")
                {
                    if(elements[i].ulCorner.Y >= SettingsForm.settings.height)
                    {
                        currentScore.points -= 3;
                        elements.Remove(elements[i]);
                        continue;
                    }
                }
                else
                {
                    if (!(elements[i].type.Equals(bombType) || elements[i].type.Equals("GameOverBomb")) && elements[i].ulCorner.Y >= SettingsForm.settings.height)
                    {
                        currentScore.points -= 3;
                        elements.Remove(elements[i]);
                        continue;
                    }
                }
            }
        }

        public bool checkClick(Point point)
        {
            foreach (Element el in elements)
            {
                if (el.isClicked(point))
                {
                    if(SettingsForm.settings.difficulty == "EASY")
                    {
                        currentScore.settleScore(5);
                    }
                    else
                    {
                        if (el.type.Equals(bombType))
                        {
                            currentScore.settleScore(-10);
                            bombsClicked++;
                        }
                        else if (el.type.Equals("GameOverBomb"))
                            return true;
                        else
                            currentScore.settleScore(5);
                    }

                    elements.Remove(el);

                    if (bombsClicked == 3)
                        return true;
                    break;
                }
            }
            return false;
        }
    }
}
