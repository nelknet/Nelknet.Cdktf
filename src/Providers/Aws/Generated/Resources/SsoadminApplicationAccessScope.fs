namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminApplicationAccessScopeState<'ApplicationArn, 'Scope> = { assignments: ResizeArray<aws.SsoadminApplicationAccessScope.SsoadminApplicationAccessScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_access_scope">aws_ssoadmin_application_access_scope</a>.
    /// </summary>
    type SsoadminApplicationAccessScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminApplicationAccessScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminApplicationAccessScopeState<Missing, Missing>)

        member _.Zero(()) : SsoadminApplicationAccessScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminApplicationAccessScopeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_access_scope#application_arn-1">SsoadminApplicationAccessScope#application_arn</a>.
        /// </summary>
        [<CustomOperation "application_arn">]
        member _.ApplicationArn(state: SsoadminApplicationAccessScopeState<Missing, 'Scope>, value: string) : SsoadminApplicationAccessScopeState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.ApplicationArn <- value)
            ({ assignments = state.assignments } : SsoadminApplicationAccessScopeState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_access_scope#scope-1">SsoadminApplicationAccessScope#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: SsoadminApplicationAccessScopeState<'ApplicationArn, Missing>, value: string) : SsoadminApplicationAccessScopeState<'ApplicationArn, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : SsoadminApplicationAccessScopeState<'ApplicationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_access_scope#authorized_targets-1">SsoadminApplicationAccessScope#authorized_targets</a>.
        /// </summary>
        [<CustomOperation "authorized_targets">]
        member _.AuthorizedTargets(state: SsoadminApplicationAccessScopeState<'ApplicationArn, 'Scope>, value: seq<string>) : SsoadminApplicationAccessScopeState<'ApplicationArn, 'Scope> =
            state.assignments.Add(fun config -> config.AuthorizedTargets <- (value |> Seq.toArray))
            state : SsoadminApplicationAccessScopeState<'ApplicationArn, 'Scope>

        member _.Run(state: SsoadminApplicationAccessScopeState<Present, Present>) : aws.SsoadminApplicationAccessScope.SsoadminApplicationAccessScope =
            let config = aws.SsoadminApplicationAccessScope.SsoadminApplicationAccessScopeConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminApplicationAccessScope.SsoadminApplicationAccessScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminApplicationAccessScope: missing required arguments. Must call: application_arn, scope.", 9999, IsError = true)>]
        member _.Run(_: SsoadminApplicationAccessScopeState<_, _>) : aws.SsoadminApplicationAccessScope.SsoadminApplicationAccessScope =
            Unchecked.defaultof<aws.SsoadminApplicationAccessScope.SsoadminApplicationAccessScope>
