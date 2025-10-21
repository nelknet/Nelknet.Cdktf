namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2InstanceTypesState = { assignments: ResizeArray<aws.DataAwsEc2InstanceTypes.DataAwsEc2InstanceTypesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_types">aws_ec2_instance_types</a>.
    /// </summary>
    type DataAwsEc2InstanceTypesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2InstanceTypesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2InstanceTypesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_types#filter-1">DataAwsEc2InstanceTypes#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2InstanceTypes.DataAwsEc2InstanceTypesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2InstanceTypesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2InstanceTypesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2InstanceTypesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_types#id-1">DataAwsEc2InstanceTypes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2InstanceTypesState, value: string) : DataAwsEc2InstanceTypesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2InstanceTypesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_types#timeouts-1">DataAwsEc2InstanceTypes#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2InstanceTypesState, value: aws.DataAwsEc2InstanceTypes.DataAwsEc2InstanceTypesTimeouts) : DataAwsEc2InstanceTypesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2InstanceTypesState

        member _.Run(state: DataAwsEc2InstanceTypesState) : aws.DataAwsEc2InstanceTypes.DataAwsEc2InstanceTypes =
            let config = aws.DataAwsEc2InstanceTypes.DataAwsEc2InstanceTypesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2InstanceTypes.DataAwsEc2InstanceTypes(StackContext.get (), logicalId, config)
