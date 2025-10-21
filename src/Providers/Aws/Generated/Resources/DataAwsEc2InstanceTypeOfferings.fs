namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2InstanceTypeOfferingsState = { assignments: ResizeArray<aws.DataAwsEc2InstanceTypeOfferings.DataAwsEc2InstanceTypeOfferingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offerings">aws_ec2_instance_type_offerings</a>.
    /// </summary>
    type DataAwsEc2InstanceTypeOfferingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2InstanceTypeOfferingsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2InstanceTypeOfferingsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offerings#filter-1">DataAwsEc2InstanceTypeOfferings#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2InstanceTypeOfferings.DataAwsEc2InstanceTypeOfferingsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2InstanceTypeOfferingsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2InstanceTypeOfferingsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2InstanceTypeOfferingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offerings#id-1">DataAwsEc2InstanceTypeOfferings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2InstanceTypeOfferingsState, value: string) : DataAwsEc2InstanceTypeOfferingsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2InstanceTypeOfferingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offerings#location_type-1">DataAwsEc2InstanceTypeOfferings#location_type</a>.
        /// </summary>
        [<CustomOperation "location_type">]
        member _.LocationType(state: DataAwsEc2InstanceTypeOfferingsState, value: string) : DataAwsEc2InstanceTypeOfferingsState =
            state.assignments.Add(fun config -> config.LocationType <- value)
            state : DataAwsEc2InstanceTypeOfferingsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offerings#timeouts-1">DataAwsEc2InstanceTypeOfferings#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2InstanceTypeOfferingsState, value: aws.DataAwsEc2InstanceTypeOfferings.DataAwsEc2InstanceTypeOfferingsTimeouts) : DataAwsEc2InstanceTypeOfferingsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2InstanceTypeOfferingsState

        member _.Run(state: DataAwsEc2InstanceTypeOfferingsState) : aws.DataAwsEc2InstanceTypeOfferings.DataAwsEc2InstanceTypeOfferings =
            let config = aws.DataAwsEc2InstanceTypeOfferings.DataAwsEc2InstanceTypeOfferingsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2InstanceTypeOfferings.DataAwsEc2InstanceTypeOfferings(StackContext.get (), logicalId, config)
