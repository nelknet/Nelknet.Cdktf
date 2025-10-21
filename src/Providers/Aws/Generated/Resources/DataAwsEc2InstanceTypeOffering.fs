namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2InstanceTypeOfferingState = { assignments: ResizeArray<aws.DataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering">aws_ec2_instance_type_offering</a>.
    /// </summary>
    type DataAwsEc2InstanceTypeOfferingBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2InstanceTypeOfferingState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2InstanceTypeOfferingState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#filter-1">DataAwsEc2InstanceTypeOffering#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2InstanceTypeOfferingState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2InstanceTypeOfferingState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2InstanceTypeOfferingState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#id-1">DataAwsEc2InstanceTypeOffering#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2InstanceTypeOfferingState, value: string) : DataAwsEc2InstanceTypeOfferingState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2InstanceTypeOfferingState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#location_type-1">DataAwsEc2InstanceTypeOffering#location_type</a>.
        /// </summary>
        [<CustomOperation "location_type">]
        member _.LocationType(state: DataAwsEc2InstanceTypeOfferingState, value: string) : DataAwsEc2InstanceTypeOfferingState =
            state.assignments.Add(fun config -> config.LocationType <- value)
            state : DataAwsEc2InstanceTypeOfferingState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#preferred_instance_types-1">DataAwsEc2InstanceTypeOffering#preferred_instance_types</a>.
        /// </summary>
        [<CustomOperation "preferred_instance_types">]
        member _.PreferredInstanceTypes(state: DataAwsEc2InstanceTypeOfferingState, value: seq<string>) : DataAwsEc2InstanceTypeOfferingState =
            state.assignments.Add(fun config -> config.PreferredInstanceTypes <- (value |> Seq.toArray))
            state : DataAwsEc2InstanceTypeOfferingState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#timeouts-1">DataAwsEc2InstanceTypeOffering#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2InstanceTypeOfferingState, value: aws.DataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingTimeouts) : DataAwsEc2InstanceTypeOfferingState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2InstanceTypeOfferingState

        member _.Run(state: DataAwsEc2InstanceTypeOfferingState) : aws.DataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOffering =
            let config = aws.DataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOffering(StackContext.get (), logicalId, config)
