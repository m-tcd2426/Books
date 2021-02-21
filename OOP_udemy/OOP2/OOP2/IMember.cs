
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public interface IMember
    {
        float Rate { get; }
        string GetName();
    }

    //public sealed class SilverMember : IMember
    //{
    //    public float Rate => 1.0f;
    //    public string GetName()
    //    {
    //        return "シルバー";
    //    }
    //}
    //public sealed class GoldMember : IMember
    //{
    //    public float Rate => 0.8f;
    //    public string GetName()
    //    {
    //        return "ゴールド";
    //    }
    //}
    //public sealed class PlatinumMember : IMember
    //{
    //    public float Rate => 0.6f;
    //    public string GetName()
    //    {
    //        return "プラチナ";
    //    }
    //}

}
