using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    interface IFlyable
    {
        void Fly();
    }

    interface ISwimmable
    {
        void Swim();
    }

    interface IRollable
    {
        void Roll();
    }

    interface IWalkable
    {
        void Walk();
    }

    interface IAlive
    {
        void Breath();
    }
}
