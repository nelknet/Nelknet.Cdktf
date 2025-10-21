namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElbHostedZoneIdState = { assignments: ResizeArray<aws.DataAwsElbHostedZoneId.DataAwsElbHostedZoneIdConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb_hosted_zone_id">aws_elb_hosted_zone_id</a>.
    /// </summary>
    type DataAwsElbHostedZoneIdBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElbHostedZoneIdState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsElbHostedZoneIdState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb_hosted_zone_id#id-1">DataAwsElbHostedZoneId#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElbHostedZoneIdState, value: string) : DataAwsElbHostedZoneIdState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElbHostedZoneIdState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb_hosted_zone_id#region-1">DataAwsElbHostedZoneId#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsElbHostedZoneIdState, value: string) : DataAwsElbHostedZoneIdState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsElbHostedZoneIdState

        member _.Run(state: DataAwsElbHostedZoneIdState) : aws.DataAwsElbHostedZoneId.DataAwsElbHostedZoneId =
            let config = aws.DataAwsElbHostedZoneId.DataAwsElbHostedZoneIdConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElbHostedZoneId.DataAwsElbHostedZoneId(StackContext.get (), logicalId, config)
