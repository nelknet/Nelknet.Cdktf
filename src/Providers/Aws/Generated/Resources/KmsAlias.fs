namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KmsAliasState<'TargetKeyId> = { assignments: ResizeArray<aws.KmsAlias.KmsAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_alias">aws_kms_alias</a>.
    /// </summary>
    type KmsAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : KmsAliasState<Missing> =
            ({ assignments = ResizeArray() } : KmsAliasState<Missing>)

        member _.Zero(()) : KmsAliasState<Missing> =
            ({ assignments = ResizeArray() } : KmsAliasState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_alias#target_key_id-1">KmsAlias#target_key_id</a>.
        /// </summary>
        [<CustomOperation "target_key_id">]
        member _.TargetKeyId(state: KmsAliasState<Missing>, value: string) : KmsAliasState<Present> =
            state.assignments.Add(fun config -> config.TargetKeyId <- value)
            ({ assignments = state.assignments } : KmsAliasState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_alias#id-1">KmsAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KmsAliasState<'TargetKeyId>, value: string) : KmsAliasState<'TargetKeyId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KmsAliasState<'TargetKeyId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_alias#name-1">KmsAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KmsAliasState<'TargetKeyId>, value: string) : KmsAliasState<'TargetKeyId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : KmsAliasState<'TargetKeyId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_alias#name_prefix-1">KmsAlias#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: KmsAliasState<'TargetKeyId>, value: string) : KmsAliasState<'TargetKeyId> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : KmsAliasState<'TargetKeyId>

        member _.Run(state: KmsAliasState<Present>) : aws.KmsAlias.KmsAlias =
            let config = aws.KmsAlias.KmsAliasConfig()
            for setter in state.assignments do
                setter config
            aws.KmsAlias.KmsAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kmsAlias: missing required arguments. Must call: target_key_id.", 9999, IsError = true)>]
        member _.Run(_: KmsAliasState<_>) : aws.KmsAlias.KmsAlias =
            Unchecked.defaultof<aws.KmsAlias.KmsAlias>
