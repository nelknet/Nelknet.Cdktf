using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbInstance
{
    [JsiiInterface(nativeType: typeof(IDbInstanceListenerEndpoint), fullyQualifiedName: "aws.dbInstance.DbInstanceListenerEndpoint")]
    public interface IDbInstanceListenerEndpoint
    {

        [JsiiTypeProxy(nativeType: typeof(IDbInstanceListenerEndpoint), fullyQualifiedName: "aws.dbInstance.DbInstanceListenerEndpoint")]
        internal sealed class _Proxy : DeputyBase, aws.DbInstance.IDbInstanceListenerEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
