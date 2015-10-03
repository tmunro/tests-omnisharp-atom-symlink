using UnityEngine;

namespace Test
{
    public class SymlinkTest2 : MonoBehaviour
    {
        public void MethodA()
        {
            var sym = gameObject.AddComponent<SymlinkTest>();
            sym.MethodA();
            return;
        }
        public void MethodB()
        {
            return;
        }
    }
}
