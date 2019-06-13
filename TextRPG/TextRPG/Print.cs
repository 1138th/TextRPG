using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextRPG
{
    class Print
    {
        static public void Print1(string txt)
        {
            Console.Clear();
            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Thread.Sleep(3);
            }
        }
        static public void Print2(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Thread.Sleep(3);
            }
        }
        public static void Status(CharacterInfo character)
        {
            character.LongTime = DateTime.Now;
            character.ShortTime = character.LongTime.ToString();
            int expdifference = character.Exptolvlup - character.Exp;
            string txt;
            if (expdifference > 0)
            {
                txt = string.Format(
                    "Персонаж: {0}.\nДень {1}.\nВремя: {2}.\nУровень персонажа: {3}.\nОпыта до повышения уровня: {4}.\nВыносливость: {5}.\nСила: {6}\nЗолото: {7}\n\n",
                    character.Name, character.Day, character.ShortTime, character.Lvl, expdifference, character.Stamina, character.Strength, character.Gold);
                Console.Clear();
                Console.WriteLine(txt);
            }
            else
            {
                character.Lvl++;
                character.Strength += 5;
                character.Exptolvlup += 30;
                character.Exp = 1;
                txt = string.Format("Поздравляем! Вы достигли нового уровня и получаете небольшую прибавку к силе!\n\n");
                Print.Print2(txt);
            }
        }
    }
}