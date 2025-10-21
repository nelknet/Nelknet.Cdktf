using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbInstance
{
    [JsiiInterface(nativeType: typeof(IDbInstanceMasterUserSecret), fullyQualifiedName: "aws.dbInstance.DbInstanceMasterUserSecret")]
    public interface IDbInstanceMasterUserSecret
    {

        [JsiiTypeProxy(nativeType: typeof(IDbInstanceMasterUserSecret), fullyQualifiedName: "aws.dbInstance.DbInstanceMasterUserSecret")]
        internal sealed class _Proxy : DeputyBase, aws.DbInstance.IDbInstanceMasterUserSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
