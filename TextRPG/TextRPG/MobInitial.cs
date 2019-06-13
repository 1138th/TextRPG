using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class MobInitial
    {

    }
    class WoodMobs
    {
        public MobsInfo
            wolf = new MobsInfo(),
            bear = new MobsInfo(),
            racoon = new MobsInfo(),
            fox = new MobsInfo(),
            hawk = new MobsInfo(),
            gryphon = new MobsInfo(),
            posion_ivy = new MobsInfo(),
            boar = new MobsInfo(),
            snake = new MobsInfo();
        public WoodMobs()
        {
            posion_ivy.Name = "ядовитый плющ";
            posion_ivy.Strength = 10;
            posion_ivy.Exp = 5;
            posion_ivy.Gold = 5;
            racoon.Name = "енот";
            racoon.Strength = 10;
            racoon.Exp = 7;
            racoon.Gold = 10;
            fox.Name = "лис";
            fox.Strength = 10;
            fox.Exp = 10;
            fox.Gold = 15;
            snake.Name = "змей";
            snake.Strength = 15;
            snake.Exp = 15;
            snake.Gold = 20;
            hawk.Name = "ястреб";
            hawk.Strength = 20;
            hawk.Exp = 25;
            hawk.Gold = 30;
            boar.Name = "дикий кабан";
            boar.Strength = 25;
            boar.Exp = 30;
            boar.Gold = 35;
            wolf.Name = "волк";
            wolf.Strength = 30;
            wolf.Exp = 35;
            wolf.Gold = 40;
            bear.Name = "медведь";
            bear.Strength = 35;
            bear.Exp = 40;
            bear.Gold = 45;
            gryphon.Name = "грифон";
            gryphon.Strength = 50;
            gryphon.Exp = 50;
            gryphon.Gold = 50;
        }
    }
    class CaveMobs
    {
        public MobsInfo
            orc = new MobsInfo(),
            spider = new MobsInfo(),
            troll = new MobsInfo(),
            werewlolf = new MobsInfo(),
            gobelin = new MobsInfo(),
            minotaur = new MobsInfo(),
            basilisk = new MobsInfo(),
            lizard = new MobsInfo(),
            varan = new MobsInfo();
        public CaveMobs()
        {
            varan.Name = "варан";
            varan.Strength = 50;
            varan.Exp = 50;
            varan.Gold = 50;
            orc.Name = "орк";
            orc.Strength = 50;
            orc.Exp = 50;
            orc.Gold = 50;
            gobelin.Name = "гоблин";
            gobelin.Strength = 60;
            gobelin.Exp = 55;
            gobelin.Gold = 60;
            lizard.Name = "кристальный скорпион";
            lizard.Strength = 70;
            lizard.Exp = 60;
            lizard.Gold = 70;
            spider.Name = "гигантский паук";
            spider.Strength = 80;
            spider.Exp = 65;
            spider.Gold = 80;
            troll.Name = "горный тролль";
            troll.Strength = 90;
            troll.Exp = 70;
            troll.Gold = 90;
            basilisk.Name = "василиск";
            basilisk.Strength = 100;
            basilisk.Exp = 75;
            basilisk.Gold = 100;
            minotaur.Name = "минотавр";
            minotaur.Strength = 110;
            minotaur.Exp = 80;
            minotaur.Gold = 110;
            werewlolf.Name = "оборотень";
            werewlolf.Strength = 120;
            werewlolf.Exp = 90;
            werewlolf.Gold = 120;
        }
    }
}