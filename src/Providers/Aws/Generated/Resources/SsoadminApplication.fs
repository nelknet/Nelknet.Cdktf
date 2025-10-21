namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name> = { assignments: ResizeArray<aws.SsoadminApplication.SsoadminApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application">aws_ssoadmin_application</a>.
    /// </summary>
    type SsoadminApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : SsoadminApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#application_provider_arn-1">SsoadminApplication#application_provider_arn</a>.
        /// </summary>
        [<CustomOperation "application_provider_arn">]
        member _.ApplicationProviderArn(state: SsoadminApplicationState<Missing, 'InstanceArn, 'Name>, value: string) : SsoadminApplicationState<Present, 'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.ApplicationProviderArn <- value)
            ({ assignments = state.assignments } : SsoadminApplicationState<Present, 'InstanceArn, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#instance_arn-1">SsoadminApplication#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminApplicationState<'ApplicationProviderArn, Missing, 'Name>, value: string) : SsoadminApplicationState<'ApplicationProviderArn, Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminApplicationState<'ApplicationProviderArn, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#name-1">SsoadminApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, Missing>, value: string) : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#client_token-1">SsoadminApplication#client_token</a>.
        /// </summary>
        [<CustomOperation "client_token">]
        member _.ClientToken(state: SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>, value: string) : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.ClientToken <- value)
            state : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#description-1">SsoadminApplication#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>, value: string) : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>

        /// <summary>
        /// portal_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#portal_options-1">SsoadminApplication#portal_options</a> Accepts: aws.IResolvable | aws.SsoadminApplication.SsoadminApplicationPortalOptions[]
        /// </summary>
        [<CustomOperation "portal_options">]
        member _.PortalOptions(state: SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.PortalOptions <- value)
            state : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#status-1">SsoadminApplication#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>, value: string) : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#tags-1">SsoadminApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>, value: seq<string * string>) : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsoadminApplicationState<'ApplicationProviderArn, 'InstanceArn, 'Name>

        member _.Run(state: SsoadminApplicationState<Present, Present, Present>) : aws.SsoadminApplication.SsoadminApplication =
            let config = aws.SsoadminApplication.SsoadminApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminApplication.SsoadminApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminApplication: missing required arguments. Must call: application_provider_arn, instance_arn, name.", 9999, IsError = true)>]
        member _.Run(_: SsoadminApplicationState<_, _, _>) : aws.SsoadminApplication.SsoadminApplication =
            Unchecked.defaultof<aws.SsoadminApplication.SsoadminApplication>
