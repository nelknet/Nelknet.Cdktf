using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectHoursOfOperation
{
    [JsiiInterface(nativeType: typeof(IConnectHoursOfOperationConfigStartTime), fullyQualifiedName: "aws.connectHoursOfOperation.ConnectHoursOfOperationConfigStartTime")]
    public interface IConnectHoursOfOperationConfigStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#hours ConnectHoursOfOperation#hours}.</summary>
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}")]
        double Hours
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#minutes ConnectHoursOfOperation#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
        double Minutes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectHoursOfOperationConfigStartTime), fullyQualifiedName: "aws.connectHoursOfOperation.ConnectHoursOfOperationConfigStartTime")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#hours ConnectHoursOfOperation#hours}.</summary>
            [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}")]
            public double Hours
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#minutes ConnectHoursOfOperation#minutes}.</summary>
            [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
            public double Minutes
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
