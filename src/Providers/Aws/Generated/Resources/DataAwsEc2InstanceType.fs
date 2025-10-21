namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2InstanceTypeState<'InstanceType> = { assignments: ResizeArray<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type">aws_ec2_instance_type</a>.
    /// </summary>
    type DataAwsEc2InstanceTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2InstanceTypeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2InstanceTypeState<Missing>)

        member _.Zero(()) : DataAwsEc2InstanceTypeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2InstanceTypeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type#instance_type-1">DataAwsEc2InstanceType#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: DataAwsEc2InstanceTypeState<Missing>, value: string) : DataAwsEc2InstanceTypeState<Present> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : DataAwsEc2InstanceTypeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type#id-1">DataAwsEc2InstanceType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2InstanceTypeState<'InstanceType>, value: string) : DataAwsEc2InstanceTypeState<'InstanceType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2InstanceTypeState<'InstanceType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type#timeouts-1">DataAwsEc2InstanceType#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2InstanceTypeState<'InstanceType>, value: aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeouts) : DataAwsEc2InstanceTypeState<'InstanceType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2InstanceTypeState<'InstanceType>

        member _.Run(state: DataAwsEc2InstanceTypeState<Present>) : aws.DataAwsEc2InstanceType.DataAwsEc2InstanceType =
            let config = aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2InstanceType.DataAwsEc2InstanceType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEc2InstanceType: missing required arguments. Must call: instance_type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEc2InstanceTypeState<_>) : aws.DataAwsEc2InstanceType.DataAwsEc2InstanceType =
            Unchecked.defaultof<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceType>
