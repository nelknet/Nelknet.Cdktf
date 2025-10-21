using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectHoursOfOperation
{
    [JsiiInterface(nativeType: typeof(IConnectHoursOfOperationConfigA), fullyQualifiedName: "aws.connectHoursOfOperation.ConnectHoursOfOperationConfigA")]
    public interface IConnectHoursOfOperationConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#day ConnectHoursOfOperation#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        string Day
        {
            get;
        }

        /// <summary>end_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#end_time ConnectHoursOfOperation#end_time}
        /// </remarks>
        [JsiiProperty(name: "endTime", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigEndTime\"}")]
        aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime EndTime
        {
            get;
        }

        /// <summary>start_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#start_time ConnectHoursOfOperation#start_time}
        /// </remarks>
        [JsiiProperty(name: "startTime", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigStartTime\"}")]
        aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime StartTime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectHoursOfOperationConfigA), fullyQualifiedName: "aws.connectHoursOfOperation.ConnectHoursOfOperationConfigA")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#day ConnectHoursOfOperation#day}.</summary>
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
            public string Day
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>end_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#end_time ConnectHoursOfOperation#end_time}
            /// </remarks>
            [JsiiProperty(name: "endTime", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigEndTime\"}")]
            public aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime EndTime
            {
                get => GetInstanceProperty<aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime>()!;
            }

            /// <summary>start_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#start_time ConnectHoursOfOperation#start_time}
            /// </remarks>
            [JsiiProperty(name: "startTime", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigStartTime\"}")]
            public aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime StartTime
            {
                get => GetInstanceProperty<aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime>()!;
            }
        }
    }
}
