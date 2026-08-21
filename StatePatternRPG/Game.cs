using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace StatePatternRPG
{
    internal class Game(IGameController controller)
    {
        private enum RoomType
        {
            Empty,
            Trap,
            Enemy,
            DeadEnd
        }
        private enum Trapstatus
        {
            Disarmed,
            Discovered,
            Undiscovered,
        }
        private IGameController _gameController = controller;
        private RoomType _room = RoomType.Empty;

        private Trapstatus _trapstatus = Trapstatus.Disarmed;

        private Random _random = new();
        public void Run()
        {
            while(CanContinue())
            {
                switch(_gameController.GetInput())
                {
                    case GameCommand.Attack:
                        Attack();
                        break;
                    case GameCommand.Proceed:
                        Proceed();
                        break;
                    case GameCommand.Observe:
                        Observe();
                        break;
                    case GameCommand.Interact:
                        Interact();
                        break;
                }

            }
        }

        private void Interact()
        {
            switch (_room)
            {
                case RoomType.Trap:
                    if(_trapstatus == Trapstatus.Discovered)
                    {
                        _trapstatus = Trapstatus.Disarmed;
                        //falle entschärft dialog
                        break;
                    }
                    //interact empty
                    break;
                case RoomType.Enemy:
                    //interact enemy
                    break;
                case RoomType.Empty:
                    //interact empty
                default:
                    throw new Exception();
            }
        }

        private void Observe()
        {
            switch (_room)
            {
                case RoomType.Trap:
                    if (_trapstatus == Trapstatus.Undiscovered)
                    {
                        _trapstatus = Trapstatus.Discovered;
                        //falle entdeckt dialog
                        break;
                    }
                    //falle bereits entdeckt
                    break;
                case RoomType.Enemy:
                    //observe enemy
                    break;
                case RoomType.Empty:
                    //observe empty
                default:
                    throw new Exception();
            }
        }

        private void Proceed()
        {
            switch (_room)
            {
                case RoomType.Trap:
                    if (_trapstatus != Trapstatus.Disarmed)
                    {
                        _room = RoomType.DeadEnd;
                        //tod dialog
                        return;
                    }
                    break;
                case RoomType.Enemy:
                    _room = RoomType.DeadEnd;
                    //tod dialog
                    return;
                default:
                    break;
            }
            //proceed dialog
            _room = GetRandomRoom();
        }

        private void Attack()
        {
            switch (_room)
            {
                case RoomType.Enemy:
                    _room = RoomType.Empty;
                    //dialog kill enemy
                    break;
                default:
                    //empty attack
                    break;
            }
        }

        private bool CanContinue()
        {
            return _room != RoomType.DeadEnd;
        }

        private RoomType GetRandomRoom()
        {
            return (RoomType)_random.Next(0, 3);
        }
    }
}
