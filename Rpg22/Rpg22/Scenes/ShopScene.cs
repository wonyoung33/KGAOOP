using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg22.Scenes
{
    public class ShopScene : Scene
    {

        private string input;
        public ShopScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            // TODO : 아이템 설정

            Console.Clear();
            Console.WriteLine("상점에 들어갑니다...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            // TODO : 상점 입력
            input = Console.ReadLine();
        }

        public override void Render()
        {
            // TODO : 상점 상황 출력
            for (int i = 0; i < game.items.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.{game.items[i].name} : {game.items[i].price}");
            }
        }

        public override void Update()
        {
            // TODO : 상점 처리
            if(input == "1")
            {
                game.inventory.AddItem(game.items[0]);
            }
            if (input == "2")
            {
                game.inventory.AddItem(game.items[1]);
            }
            if (input == "3")
            {
                game.inventory.AddItem(game.items[2]);
            }

            Thread.Sleep(2000);
            
            game.ChangeScene(SceneType.Inventory);
        }
    }
}
