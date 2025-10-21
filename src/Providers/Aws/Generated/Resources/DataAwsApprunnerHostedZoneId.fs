namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApprunnerHostedZoneIdState = { assignments: ResizeArray<aws.DataAwsApprunnerHostedZoneId.DataAwsApprunnerHostedZoneIdConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apprunner_hosted_zone_id">aws_apprunner_hosted_zone_id</a>.
    /// </summary>
    type DataAwsApprunnerHostedZoneIdBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApprunnerHostedZoneIdState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsApprunnerHostedZoneIdState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apprunner_hosted_zone_id#region-1">DataAwsApprunnerHostedZoneId#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsApprunnerHostedZoneIdState, value: string) : DataAwsApprunnerHostedZoneIdState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsApprunnerHostedZoneIdState

        member _.Run(state: DataAwsApprunnerHostedZoneIdState) : aws.DataAwsApprunnerHostedZoneId.DataAwsApprunnerHostedZoneId =
            let config = aws.DataAwsApprunnerHostedZoneId.DataAwsApprunnerHostedZoneIdConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApprunnerHostedZoneId.DataAwsApprunnerHostedZoneId(StackContext.get (), logicalId, config)
