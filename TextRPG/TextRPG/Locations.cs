using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextRPG
{
    class Locations
    {
        protected string txt;
        protected int q;
        protected Random rand;
        protected int i;
        protected WoodMobs wmobs;
        protected CaveMobs cmobs;
        public Locations()
        {
            rand = new Random();
            wmobs = new WoodMobs();
            cmobs = new CaveMobs();
        }
        public void Camp(CharacterInfo character)
        {
            if (character.Stamina == 0)
            {
                txt = "У Вас 0 выносливости - вы не можете выполнять действия.\n" +
                    "Введите \"отдых\" для восполнения выносливости.";
                Print.Print2(txt);
                do
                {
                    q = 0;
                    txt = Console.ReadLine();
                    switch (txt)
                    {
                        case "отдых":
                            character.Day++;
                            character.Stamina = 15;
                            txt = "Выносливость восстанавливается...\n";
                            Print.Print2(txt);
                            txt = "Выносливость восстановлена! Можете начать новый день полными энергии";
                            Thread.Sleep(15000);
                            Print.Print2(txt);
                            Console.ReadKey();
                            break;
                        default:
                            txt = "Вы не можете ввести что-либо, кроме действия \"отдых\", т.к. у Вас нет выносливости.\n";
                            Print.Print2(txt);
                            q = 1;
                            break;
                    }
                } while (q == 1);
                Camp(character);
            }
            txt = "Вы находитесь в лагере.\n\n" +
                "Доступные действия:\n" +
                "\"лес\" - отправиться в лес искать и убивать лесных монстров;\n" +
                "\"пещера\" - искать в пещере неприятности и пещерных монстров, возможно нахождение клада;\n" +
                "\"деревня\" - завершить игру;\n" +
                "\"отдых\" - отдохнуть и восполнить силы.\n" +
                "Ваши действия?\n\n";
            string txt2;
            Print.Status(character);
            Print.Print2(txt);
            do
            {
                q = 0;
                txt2 = Console.ReadLine();
                switch (txt2)
                {
                    case "лес":
                        Wood(character);
                        break;
                    case "пещера":
                        if (character.Strength <= 60)
                        {
                            txt = "Вы должны достичь 12 уровня, чтобы открыть доступ к локации.";
                            Print.Print2(txt);
                            Console.ReadKey();
                            Camp(character);
                        }
                        Cave(character);
                        break;
                    case "деревня":
                        Village(character);
                        break;
                    case "отдых":
                        character.Day++;
                        character.Stamina = 15;
                        txt = "Выносливость восстанавливается...\n";
                        Print.Print2(txt);
                        txt = "Выносливость восстановлена! Можете начать новый день полными энергии";
                        Thread.Sleep(15000);
                        Print.Print2(txt);
                        Console.ReadKey();
                        Camp(character);
                        break;
                    default:
                        q = 1;
                        txt = "Вы некорректно ввели действие, которое необходимо совершить, или вообще не ввели его, попробуйте ещё раз.\n\n";
                        Print.Print2(txt);
                        break;
                }
            } while (q == 1);
        }
        private void Wood(CharacterInfo character)
        {
            character.Stamina--;
            string txt = "Вы в лесу.\n\n";
            Print.Status(character);
            Print.Print2(txt);
            i = rand.Next(1, 10);
            character.Itsvictory = 0;
            switch (i)
            {
                case 1:
                    BattleWood(character, wmobs.posion_ivy);
                    i = rand.Next(3);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Posion_stem++;
                        txt = "Вы получили: стебель ядовитого  плюща.\n"; //Вероятность выпадения: 50%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    BattleWood(character, wmobs.racoon);
                    i = rand.Next(4);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Racoon_skin++;
                        txt = "Вы получили: шкура енота.\n"; //Вероятность выпадения: 33%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    BattleWood(character, wmobs.fox);
                    i = rand.Next(4);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Fox_skin++;
                        txt = "Вы получили: лисья шкура.\n"; //Вероятность выпадения: 33%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
                case 4:
                    BattleWood(character, wmobs.snake);
                    i = rand.Next(5);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Snake_canine++;
                        txt = "Вы получили: клык змеи.\n"; //Вероятность выпадения: 25%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
                case 5:
                    BattleWood(character, wmobs.hawk);
                    i = rand.Next(5);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Hawk_pen++;
                        txt = "Вы получили: перо ястреба.\n"; //Вероятность выпадения: 25%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
                case 6:
                    BattleWood(character, wmobs.boar);
                    i = rand.Next(5);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Boar_skin++;
                        txt = "Вы получили: шкура дикого кабана.\n"; //Вероятность выпадения: 25%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
                case 7:
                    BattleWood(character, wmobs.wolf);
                    i = rand.Next(6);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Wolf_skin++;
                        txt = "Вы получили: шкура волка.\n"; //Вероятность выпадения: 20%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
                case 8:
                    BattleWood(character, wmobs.bear);
                    i = rand.Next(6);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Bear_skin++;
                        txt = "Вы получили: шкура медведя.\n"; //Вероятность выпадения: 20%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
                case 9:
                    BattleWood(character, wmobs.gryphon);
                    if (character.Itsvictory == 1) character.Gryphon_killed++;
                    i = rand.Next(11);
                    if (character.Itsvictory == 1 && i == 1)
                    {
                        character.Gryphon_pen++;
                        txt = "Поздравляем! Вы получили редкий предмет: перо грифона. Вы можете обменять его на нечто ценное.\n"; //Вероятность выпадения: 10%
                        Print.Print2(txt);
                        Console.ReadKey();
                    }
                    break;
            }
        }
        private void BattleWood(CharacterInfo character, MobsInfo itsmob)
        {
            int i = rand.Next(1, 4);
            string txt;
            switch (i)
            {
                case 1:
                    txt = string.Format("Вы шли по лесу и вышли на небольшую чащу, в центре которой был {0}. " +
                        "Вы вступаете в бой.\n", itsmob.Name);
                    Print.Print2(txt);
                    Console.ReadKey();
                    break;
                case 2:
                    txt = string.Format("За очередным деревом, располагающимся у лесной тропы, вдоль которой Вы шли, оказался враждебный {0}. " +
                        "Вы вступаете в бой.\n", itsmob.Name);
                    Print.Print2(txt);
                    Console.ReadKey();
                    break;
                case 3:
                    txt = string.Format("Лесная тропа заводила Вас всё глубже в лес, пока не Вы не оказались в тупике, в котором Вас уже ждал {0}. " +
                        "Вы вступаете в бой.\n", itsmob.Name);
                    Print.Print2(txt);
                    Console.ReadKey();
                    break;
            }
            string text;
            if (character.Strength >= itsmob.Strength)
            {
                text = string.Format("Вы одержали победу!\nВы возвращаетесь в лагерь, приобретя {0} опыта и {1} золота.\n", itsmob.Exp, itsmob.Gold);
                character.Exp += itsmob.Exp;
                character.Gold += itsmob.Gold;
                character.Itsvictory = 1;
                Print.Print2(text);
                Console.ReadKey();
            }
            else
            {
                text = string.Format("Вражеский {0} одержал победу! Вы возвращаетесь в лагерь ни с чем.", itsmob.Name);
                Print.Print2(text);
                Console.ReadKey();
            }
            Camp(character);
        }
        private void Cave(CharacterInfo character)
        {
            character.Stamina--;
            string txt = "Вы в пещере.\n\n";
            Print.Status(character);
            Print.Print2(txt);
            i = rand.Next(1, 10);
            character.Itsvictory = 0;
            switch (i)
            {
                case 1:
                    BattleCave(character, cmobs.varan);
                    break;
                case 2:
                    BattleCave(character, cmobs.orc);
                    break;
                case 3:
                    BattleCave(character, cmobs.gobelin);
                    break;
                case 4:
                    BattleCave(character, cmobs.lizard);
                    break;
                case 5:
                    BattleCave(character, cmobs.spider);
                    break;
                case 6:
                    BattleCave(character, cmobs.troll);
                    break;
                case 7:
                    BattleCave(character, cmobs.basilisk);
                    break;
                case 8:
                    BattleCave(character, cmobs.minotaur);
                    break;
                case 9:
                    BattleCave(character, cmobs.werewlolf);
                    if (character.Itsvictory == 1) character.Werewolf_killed++;
                    break;
            }
            Camp(character);
        }
        private void BattleCave(CharacterInfo inf, MobsInfo itsmob)
        {
            i = rand.Next(1, 4);
            string txt;
            switch (i)
            {
                case 1:
                    txt = string.Format("Вы оазались окружены сталагмитами. " +
                        "За одним из них оказался {0}. " +
                        "Вы вступаете в бой.\n", itsmob.Name);
                    Print.Print2(txt);
                    Console.ReadKey();
                    break;
                case 2:
                    txt = string.Format("Вы нашли вход в шахту и решили пойти вдоль рельсов. " +
                        "После череды поворотов влево или вправо на развилках, рельсы, наконец, закончились. " +
                        "Вас уже поджидал {0}. " +
                        "Вы вступаете в бой.\n", itsmob.Name);
                    Print.Print2(txt);
                    Console.ReadKey();
                    break;
                case 3:
                    txt = string.Format("Вы нашли пещерное озеро. " +
                        "Стоя и наблюдая красоту подземной водной глади, Вы не заметили, как сзади подкрался {0} " +
                        "Вы вступаете в бой.\n", itsmob.Name);
                    Print.Print2(txt);
                    Console.ReadKey();
                    break;
            }
            string text;
            if (inf.Strength >= itsmob.Strength)
            {
                text = string.Format("Вы одержали победу!\nВы возвращаетесь в лагерь, приобретя {0} опыта и {1} золота.\n", itsmob.Exp, itsmob.Gold);
                inf.Exp += itsmob.Exp;
                inf.Gold += itsmob.Gold;
                inf.Itsvictory++;
                Print.Print2(text);
                Console.ReadKey();
            }
            else
            {
                text = string.Format("Вражеский {0} одержал победу! Вы возвращаетесь в лагерь ни с чем.", itsmob.Name);
                Print.Print2(text);
                Console.ReadKey();
            }
        }
        private void Village(CharacterInfo character)
        {
            txt = "Вы в деревне.\n\n" +
                "Покинув деревню, вы окончательно завершите игру.\n" +
                "Доступные действия:\n" +
                "\"да\" - покинуть игру;\n" +
                "\"нет\" - вернуться в лагерь.\n" +
                "Вы уверены, что хотите покинуть деревню?\n\n";
            Print.Status(character);
            Print.Print2(txt);
            string txt2;
            int q;
            do
            {
                q = 0;
                txt2 = Console.ReadLine();
                switch (txt2)
                {
                    case "да":
                        txt = "Благодарим за игру! ;)\n";
                        Console.Clear();
                        for (int i = 0; i < txt.Length; i++)
                        {
                            Console.Write(txt[i]);
                            Thread.Sleep(500);
                        }
                        break;
                    case "нет":
                        Camp(character);
                        break;
                    default:
                        q = 1;
                        txt = "Вы некорректно ввели действие, которое необходимо совершить, или вообще не ввели его, попробуйте ещё раз.\n\n";
                        Print.Print2(txt);
                        break;
                }
            } while (q == 1);
        }
    }
}