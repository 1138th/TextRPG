using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Info
    {
        public string Name;
        public int Exp;
        public int Gold;
        public int Strength;
    }
    class MobsInfo : Info
    {

    }
    class CharacterInfo : Info
    {
        public int Lvl;
        public int Exptolvlup;
        public int Stamina;
        public int Day;
        public DateTime LongTime;
        public string ShortTime;
        public double CurrentQuest;
        public int Gryphon_killed;
        public int Werewolf_killed;
        public int KeyFragment;
        public int Key;
        public int KeyTaken;
        public int SuperKey;
        public int Earring;
        public int Itsvictory;
        public int Posion_stem;
        public int Racoon_skin;
        public int Fox_skin;
        public int Snake_canine;
        public int Hawk_pen;
        public int Boar_skin;
        public int Wolf_skin;
        public int Bear_skin;
        public int Gryphon_pen;
        public CharacterInfo()
        {
            Lvl = 1;
            Day = 1;
            Gold = 100;
            Stamina = 15;
            ShortTime = null;
            LongTime = DateTime.Now;
            Exp = 1;
            Strength = 20;
            Exptolvlup = 50;
            CurrentQuest = 0;
            KeyFragment = 0;
            Key = 0;
            SuperKey = 0;
            Earring = 0;
            Itsvictory = 0;
            Gryphon_killed = 0;
            Werewolf_killed = 0;
            Posion_stem = 0;
            Racoon_skin = 0;
            Fox_skin = 0;
            Snake_canine = 0;
            Hawk_pen = 0;
            Boar_skin = 0;
            Wolf_skin = 0;
            Bear_skin = 0;
            Gryphon_pen = 0;
            KeyTaken = 0;
        }
    }
}