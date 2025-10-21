namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorklinkFleetState<'Name> = { assignments: ResizeArray<aws.WorklinkFleet.WorklinkFleetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet">aws_worklink_fleet</a>.
    /// </summary>
    type WorklinkFleetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorklinkFleetState<Missing> =
            ({ assignments = ResizeArray() } : WorklinkFleetState<Missing>)

        member _.Zero(()) : WorklinkFleetState<Missing> =
            ({ assignments = ResizeArray() } : WorklinkFleetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#name-1">WorklinkFleet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WorklinkFleetState<Missing>, value: string) : WorklinkFleetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WorklinkFleetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#audit_stream_arn-1">WorklinkFleet#audit_stream_arn</a>.
        /// </summary>
        [<CustomOperation "audit_stream_arn">]
        member _.AuditStreamArn(state: WorklinkFleetState<'Name>, value: string) : WorklinkFleetState<'Name> =
            state.assignments.Add(fun config -> config.AuditStreamArn <- value)
            state : WorklinkFleetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#device_ca_certificate-1">WorklinkFleet#device_ca_certificate</a>.
        /// </summary>
        [<CustomOperation "device_ca_certificate">]
        member _.DeviceCaCertificate(state: WorklinkFleetState<'Name>, value: string) : WorklinkFleetState<'Name> =
            state.assignments.Add(fun config -> config.DeviceCaCertificate <- value)
            state : WorklinkFleetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#display_name-1">WorklinkFleet#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: WorklinkFleetState<'Name>, value: string) : WorklinkFleetState<'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : WorklinkFleetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#id-1">WorklinkFleet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WorklinkFleetState<'Name>, value: string) : WorklinkFleetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WorklinkFleetState<'Name>

        /// <summary>
        /// identity_provider block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#identity_provider-1">WorklinkFleet#identity_provider</a>
        /// </summary>
        [<CustomOperation "identity_provider">]
        member _.IdentityProvider(state: WorklinkFleetState<'Name>, value: aws.WorklinkFleet.WorklinkFleetIdentityProvider) : WorklinkFleetState<'Name> =
            state.assignments.Add(fun config -> config.IdentityProvider <- value)
            state : WorklinkFleetState<'Name>

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#network-1">WorklinkFleet#network</a>
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: WorklinkFleetState<'Name>, value: aws.WorklinkFleet.WorklinkFleetNetwork) : WorklinkFleetState<'Name> =
            state.assignments.Add(fun config -> config.Network <- value)
            state : WorklinkFleetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#optimize_for_end_user_location-1">WorklinkFleet#optimize_for_end_user_location</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "optimize_for_end_user_location">]
        member _.OptimizeForEndUserLocation(state: WorklinkFleetState<'Name>, value: bool) : WorklinkFleetState<'Name> =
            state.assignments.Add(fun config -> config.OptimizeForEndUserLocation <- value)
            state : WorklinkFleetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/worklink_fleet#optimize_for_end_user_location-1">WorklinkFleet#optimize_for_end_user_location</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "optimize_for_end_user_location">]
        member _.OptimizeForEndUserLocation(state: WorklinkFleetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WorklinkFleetState<'Name> =
            state.assignments.Add(fun config -> config.OptimizeForEndUserLocation <- value)
            state : WorklinkFleetState<'Name>

        member _.Run(state: WorklinkFleetState<Present>) : aws.WorklinkFleet.WorklinkFleet =
            let config = aws.WorklinkFleet.WorklinkFleetConfig()
            for setter in state.assignments do
                setter config
            aws.WorklinkFleet.WorklinkFleet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.worklinkFleet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WorklinkFleetState<_>) : aws.WorklinkFleet.WorklinkFleet =
            Unchecked.defaultof<aws.WorklinkFleet.WorklinkFleet>
