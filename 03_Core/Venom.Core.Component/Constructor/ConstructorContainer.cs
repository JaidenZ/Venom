namespace Venom.Core.Component.Constructor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 构造适配器
    /// </summary>
    public class ConstructorContainer
    {

        private IList<IConstructor> constructors;
        private static ConstructorContainer _constructorContainer;


        public ConstructorContainer()
        {
            if(constructors == null)
            {
                constructors = new List<IConstructor>();
            }

        }

        /// <summary>
        /// 获取适配器
        /// </summary>
        /// <returns></returns>
        public static ConstructorContainer GetInstance()
        {
            if(_constructorContainer == null)
            {
                _constructorContainer = new ConstructorContainer();
            }
            return _constructorContainer;
        }



    }
}
