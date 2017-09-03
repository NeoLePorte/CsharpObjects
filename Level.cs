namespace TreehouseDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers {get; set;}

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            //Run untill all invaders are destroyed or and invader reaches the end.
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders > 0)
            {


                //Each tower has  a chance to fire on invaders
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
                //Count and move the invaders that are active.
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if(invader.IsActive)
                    {
                        invader.Move();

                        if(invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }

            }
            return true;

        }
    }
}
