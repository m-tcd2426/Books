using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public abstract class Member
    {
        protected abstract float Rate { get; }
        public abstract string GetName();

        public float GetRate()
        {
            if(DateTime.Now.Day == 5)
            {
                return 0.5f;
            }

            if(DateTime.Now.Day == 30)
            {
                return 0.5f;
            }

            return Rate;
        }
    }

    public sealed class SilverMember : Member
    {
        protected override float Rate => 1.0f;

        public override string GetName()
        {
            return "シルバー";
        }
    }
    public sealed class GoldMember : Member
    {
        protected override float Rate => 0.8f;

        public override string GetName()
        {
            return "ゴールド";
        }
    }
    public sealed class PlatinumMember : Member
    {
        protected override float Rate => 0.6f;

        public override string GetName()
        {
            return "プラチナ";
        }
    }
}
