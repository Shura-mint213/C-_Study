using System;
/*Организовать принцип стрельбы и перезарядки пушки, с сопутствующими сообщениями о состоянии пушки*/
namespace Const_readonly_GUN
{
    class MyLogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"Info\t{message}");
        }
        public void Warning(string message)
        {
            Console.WriteLine($"Warning\t{message}");
        }
        public void Error(string message)
        {
            Console.WriteLine($"Error {message}");
        }
    }
    class Gun
    {
        private const string THE_GUN_IS_NOT_LOADED_MESSAGE = "Пушка не заряжена";
        private const string LOADING_THE_GUN_MESSAGE = "Заряжаю пушку";
        private const string LOADED_THE_GUN_MESSAGE = "Зарядил пушку";
        private const string THE_CANNON_IS_ALREADY_LOADED = "Пушка уже заряжена";
        private const string SHOOTING_MESSAGE = "Стреляю";
        private const string SHOT_MESSAGE = "Выстрел";
        private bool GunCondition = false;

        private readonly MyLogger myLogger;
        public Gun(MyLogger _myLogger)
        {
            myLogger = _myLogger;
        }
        public void Shooting()
        {
            myLogger.Info(SHOOTING_MESSAGE);
            if (GunCondition)
            {
                GunCondition = false;
                myLogger.Info(SHOT_MESSAGE);
            }
            else
            {
                myLogger.Warning(THE_GUN_IS_NOT_LOADED_MESSAGE);
            }
        }
        public void LoadingGun()
        {
            myLogger.Info(LOADING_THE_GUN_MESSAGE);
            if (GunCondition)
            {
                myLogger.Error(THE_CANNON_IS_ALREADY_LOADED);
            }
            else
            {
                GunCondition = true;
                myLogger.Info(LOADED_THE_GUN_MESSAGE);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(new MyLogger());
            gun.Shooting();
            gun.LoadingGun();
            gun.LoadingGun();
            gun.Shooting();
        }
    }
}
