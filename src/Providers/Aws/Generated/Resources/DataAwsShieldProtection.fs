namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsShieldProtectionState = { assignments: ResizeArray<aws.DataAwsShieldProtection.DataAwsShieldProtectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/shield_protection">aws_shield_protection</a>.
    /// </summary>
    type DataAwsShieldProtectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsShieldProtectionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsShieldProtectionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/shield_protection#protection_id-1">DataAwsShieldProtection#protection_id</a>.
        /// </summary>
        [<CustomOperation "protection_id">]
        member _.ProtectionId(state: DataAwsShieldProtectionState, value: string) : DataAwsShieldProtectionState =
            state.assignments.Add(fun config -> config.ProtectionId <- value)
            state : DataAwsShieldProtectionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/shield_protection#resource_arn-1">DataAwsShieldProtection#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: DataAwsShieldProtectionState, value: string) : DataAwsShieldProtectionState =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            state : DataAwsShieldProtectionState

        member _.Run(state: DataAwsShieldProtectionState) : aws.DataAwsShieldProtection.DataAwsShieldProtection =
            let config = aws.DataAwsShieldProtection.DataAwsShieldProtectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsShieldProtection.DataAwsShieldProtection(StackContext.get (), logicalId, config)
