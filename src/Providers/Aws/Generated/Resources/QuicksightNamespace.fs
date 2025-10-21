namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightNamespaceState<'Namespace> = { assignments: ResizeArray<aws.QuicksightNamespace.QuicksightNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_namespace">aws_quicksight_namespace</a>.
    /// </summary>
    type QuicksightNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : QuicksightNamespaceState<Missing>)

        member _.Zero(()) : QuicksightNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : QuicksightNamespaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_namespace#namespace-1">QuicksightNamespace#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: QuicksightNamespaceState<Missing>, value: string) : QuicksightNamespaceState<Present> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            ({ assignments = state.assignments } : QuicksightNamespaceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_namespace#aws_account_id-1">QuicksightNamespace#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightNamespaceState<'Namespace>, value: string) : QuicksightNamespaceState<'Namespace> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightNamespaceState<'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_namespace#identity_store-1">QuicksightNamespace#identity_store</a>.
        /// </summary>
        [<CustomOperation "identity_store">]
        member _.IdentityStore(state: QuicksightNamespaceState<'Namespace>, value: string) : QuicksightNamespaceState<'Namespace> =
            state.assignments.Add(fun config -> config.IdentityStore <- value)
            state : QuicksightNamespaceState<'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_namespace#tags-1">QuicksightNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightNamespaceState<'Namespace>, value: seq<string * string>) : QuicksightNamespaceState<'Namespace> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightNamespaceState<'Namespace>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_namespace#timeouts-1">QuicksightNamespace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightNamespaceState<'Namespace>, value: aws.QuicksightNamespace.QuicksightNamespaceTimeouts) : QuicksightNamespaceState<'Namespace> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightNamespaceState<'Namespace>

        member _.Run(state: QuicksightNamespaceState<Present>) : aws.QuicksightNamespace.QuicksightNamespace =
            let config = aws.QuicksightNamespace.QuicksightNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightNamespace.QuicksightNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightNamespace: missing required arguments. Must call: namespace.", 9999, IsError = true)>]
        member _.Run(_: QuicksightNamespaceState<_>) : aws.QuicksightNamespace.QuicksightNamespace =
            Unchecked.defaultof<aws.QuicksightNamespace.QuicksightNamespace>
