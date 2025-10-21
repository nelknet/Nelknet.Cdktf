namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLbHostedZoneIdState = { assignments: ResizeArray<aws.DataAwsLbHostedZoneId.DataAwsLbHostedZoneIdConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_hosted_zone_id">aws_lb_hosted_zone_id</a>.
    /// </summary>
    type DataAwsLbHostedZoneIdBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLbHostedZoneIdState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLbHostedZoneIdState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_hosted_zone_id#id-1">DataAwsLbHostedZoneId#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLbHostedZoneIdState, value: string) : DataAwsLbHostedZoneIdState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLbHostedZoneIdState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_hosted_zone_id#load_balancer_type-1">DataAwsLbHostedZoneId#load_balancer_type</a>.
        /// </summary>
        [<CustomOperation "load_balancer_type">]
        member _.LoadBalancerType(state: DataAwsLbHostedZoneIdState, value: string) : DataAwsLbHostedZoneIdState =
            state.assignments.Add(fun config -> config.LoadBalancerType <- value)
            state : DataAwsLbHostedZoneIdState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_hosted_zone_id#region-1">DataAwsLbHostedZoneId#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsLbHostedZoneIdState, value: string) : DataAwsLbHostedZoneIdState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsLbHostedZoneIdState

        member _.Run(state: DataAwsLbHostedZoneIdState) : aws.DataAwsLbHostedZoneId.DataAwsLbHostedZoneId =
            let config = aws.DataAwsLbHostedZoneId.DataAwsLbHostedZoneIdConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLbHostedZoneId.DataAwsLbHostedZoneId(StackContext.get (), logicalId, config)
