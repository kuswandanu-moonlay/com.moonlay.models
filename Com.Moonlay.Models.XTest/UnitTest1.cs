using Com.Moonlay.Models.XTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Com.Moonlay.Models.XTest
{
    public static class AsmExt
    {
        public static IEnumerable<Type> GetDerivedClass(this Assembly assembly, Type baseType)
        {
            if (baseType.IsInterface)
                return assembly.DefinedTypes.Where(x => baseType.IsAssignableFrom(x));
            else
                return assembly.DefinedTypes.Where(x => !x.IsAbstract && x.IsSubclassOf(baseType));
        }
    }
    public class UnitTest1
    {
        [Fact]
        public void TestAsm()
        {
            var asm = typeof(UnitTest1).Assembly;
            var e = asm.GetDerivedClass(typeof(IEntity));
        }

        [Fact]
        public void TestCovariance()
        {
            DummyEntity dummy = new DummyEntity();
            IEnumerable<DummyEntity> dummies = new List<DummyEntity>() { dummy };
            IEnumerable<StandardEntity> baseEntities = dummies;
            IEnumerable<StandardEntity<int>> standardEntities = dummies;
            IEnumerable<BaseEntity<int>> baseIntEntities = dummies;


            var cSkinnedBanana = new CovariantSkinnedBanana();
            var skinnedBanana = new SkinnedBanana();

            PeelSkinned(skinnedBanana);
        }

        void PeelSkinned(ISkinned<Fruit> skinned) { }

        void PeelCovariantSkinned(ICovariantSkinned<Fruit> skinned) { }
    }
    class Fruit { }

    class Banana : Fruit { }

    interface ICovariantSkinned<out T> { }

    interface ISkinned<out T> { }

    class CovariantSkinned<T> : ICovariantSkinned<T> { }
    class CovariantSkinnedBanana : CovariantSkinned<Banana> { }
    class Skinned<T> : ISkinned<T> { }
    class SkinnedBanana : ISkinned<Banana> { }


}
