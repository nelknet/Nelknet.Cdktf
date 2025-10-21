namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKmsAliasState<'Name> = { assignments: ResizeArray<aws.DataAwsKmsAlias.DataAwsKmsAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_alias">aws_kms_alias</a>.
    /// </summary>
    type DataAwsKmsAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKmsAliasState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsAliasState<Missing>)

        member _.Zero(()) : DataAwsKmsAliasState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKmsAliasState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_alias#name-1">DataAwsKmsAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsKmsAliasState<Missing>, value: string) : DataAwsKmsAliasState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsKmsAliasState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kms_alias#id-1">DataAwsKmsAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKmsAliasState<'Name>, value: string) : DataAwsKmsAliasState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKmsAliasState<'Name>

        member _.Run(state: DataAwsKmsAliasState<Present>) : aws.DataAwsKmsAlias.DataAwsKmsAlias =
            let config = aws.DataAwsKmsAlias.DataAwsKmsAliasConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKmsAlias.DataAwsKmsAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKmsAlias: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKmsAliasState<_>) : aws.DataAwsKmsAlias.DataAwsKmsAlias =
            Unchecked.defaultof<aws.DataAwsKmsAlias.DataAwsKmsAlias>
