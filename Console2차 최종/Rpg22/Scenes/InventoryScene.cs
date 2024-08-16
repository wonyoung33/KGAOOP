﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg22.Scenes
{
    public class InventoryScene : Scene
    {
        string input;
        public InventoryScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            // TODO : 인벤토리 설정 리스트와링크더스트 참조

            Console.Clear();
            Console.WriteLine("인벤토리를 엽니다...");
            Thread.Sleep(1000);
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            // TODO : 인벤토리 입력
            input = Console.ReadLine();
        }

        public override void Render()
        {
            // TODO : 인벤토리 상황 출력
            game.inventory.PrintInventory();
        }

        public override void Update()
        {
            // TODO : 인벤토리 처리

            game.ChangeScene(SceneType.Town);
        }
    }
}
