namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LakeformationLfTagState<'Key, 'Values> = { assignments: ResizeArray<aws.LakeformationLfTag.LakeformationLfTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_lf_tag">aws_lakeformation_lf_tag</a>.
    /// </summary>
    type LakeformationLfTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : LakeformationLfTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LakeformationLfTagState<Missing, Missing>)

        member _.Zero(()) : LakeformationLfTagState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LakeformationLfTagState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_lf_tag#key-1">LakeformationLfTag#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: LakeformationLfTagState<Missing, 'Values>, value: string) : LakeformationLfTagState<Present, 'Values> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : LakeformationLfTagState<Present, 'Values>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_lf_tag#values-1">LakeformationLfTag#values</a>.
        /// </summary>
        [<CustomOperation "values">]
        member _.Values(state: LakeformationLfTagState<'Key, Missing>, value: seq<string>) : LakeformationLfTagState<'Key, Present> =
            state.assignments.Add(fun config -> config.Values <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : LakeformationLfTagState<'Key, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_lf_tag#catalog_id-1">LakeformationLfTag#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: LakeformationLfTagState<'Key, 'Values>, value: string) : LakeformationLfTagState<'Key, 'Values> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : LakeformationLfTagState<'Key, 'Values>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_lf_tag#id-1">LakeformationLfTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LakeformationLfTagState<'Key, 'Values>, value: string) : LakeformationLfTagState<'Key, 'Values> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LakeformationLfTagState<'Key, 'Values>

        member _.Run(state: LakeformationLfTagState<Present, Present>) : aws.LakeformationLfTag.LakeformationLfTag =
            let config = aws.LakeformationLfTag.LakeformationLfTagConfig()
            for setter in state.assignments do
                setter config
            aws.LakeformationLfTag.LakeformationLfTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lakeformationLfTag: missing required arguments. Must call: key, values.", 9999, IsError = true)>]
        member _.Run(_: LakeformationLfTagState<_, _>) : aws.LakeformationLfTag.LakeformationLfTag =
            Unchecked.defaultof<aws.LakeformationLfTag.LakeformationLfTag>
