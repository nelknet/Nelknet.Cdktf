using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupResources), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupResources")]
    public interface IEksNodeGroupResources
    {

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupResources), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupResources")]
        internal sealed class _Proxy : DeputyBase, aws.EksNodeGroup.IEksNodeGroupResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
