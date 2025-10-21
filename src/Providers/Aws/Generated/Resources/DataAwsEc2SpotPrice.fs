namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2SpotPriceState = { assignments: ResizeArray<aws.DataAwsEc2SpotPrice.DataAwsEc2SpotPriceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price">aws_ec2_spot_price</a>.
    /// </summary>
    type DataAwsEc2SpotPriceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2SpotPriceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2SpotPriceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#availability_zone-1">DataAwsEc2SpotPrice#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: DataAwsEc2SpotPriceState, value: string) : DataAwsEc2SpotPriceState =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : DataAwsEc2SpotPriceState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#filter-1">DataAwsEc2SpotPrice#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2SpotPrice.DataAwsEc2SpotPriceFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2SpotPriceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2SpotPriceState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2SpotPriceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#id-1">DataAwsEc2SpotPrice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2SpotPriceState, value: string) : DataAwsEc2SpotPriceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2SpotPriceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#instance_type-1">DataAwsEc2SpotPrice#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: DataAwsEc2SpotPriceState, value: string) : DataAwsEc2SpotPriceState =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            state : DataAwsEc2SpotPriceState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#timeouts-1">DataAwsEc2SpotPrice#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2SpotPriceState, value: aws.DataAwsEc2SpotPrice.DataAwsEc2SpotPriceTimeouts) : DataAwsEc2SpotPriceState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2SpotPriceState

        member _.Run(state: DataAwsEc2SpotPriceState) : aws.DataAwsEc2SpotPrice.DataAwsEc2SpotPrice =
            let config = aws.DataAwsEc2SpotPrice.DataAwsEc2SpotPriceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2SpotPrice.DataAwsEc2SpotPrice(StackContext.get (), logicalId, config)
