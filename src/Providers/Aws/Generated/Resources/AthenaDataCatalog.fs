namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type> = { assignments: ResizeArray<aws.AthenaDataCatalog.AthenaDataCatalogConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_data_catalog">aws_athena_data_catalog</a>.
    /// </summary>
    type AthenaDataCatalogBuilder(logicalId: string) =
        member _.Yield(_: unit) : AthenaDataCatalogState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AthenaDataCatalogState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AthenaDataCatalogState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AthenaDataCatalogState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_data_catalog#description-1">AthenaDataCatalog#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AthenaDataCatalogState<Missing, 'Name, 'Parameters, 'Type>, value: string) : AthenaDataCatalogState<Present, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : AthenaDataCatalogState<Present, 'Name, 'Parameters, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_data_catalog#name-1">AthenaDataCatalog#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AthenaDataCatalogState<'Description, Missing, 'Parameters, 'Type>, value: string) : AthenaDataCatalogState<'Description, Present, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AthenaDataCatalogState<'Description, Present, 'Parameters, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_data_catalog#parameters-1">AthenaDataCatalog#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: AthenaDataCatalogState<'Description, 'Name, Missing, 'Type>, value: seq<string * string>) : AthenaDataCatalogState<'Description, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            ({ assignments = state.assignments } : AthenaDataCatalogState<'Description, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_data_catalog#type-1">AthenaDataCatalog#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AthenaDataCatalogState<'Description, 'Name, 'Parameters, Missing>, value: string) : AthenaDataCatalogState<'Description, 'Name, 'Parameters, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : AthenaDataCatalogState<'Description, 'Name, 'Parameters, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_data_catalog#id-1">AthenaDataCatalog#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type>, value: string) : AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_data_catalog#tags-1">AthenaDataCatalog#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type>, value: seq<string * string>) : AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_data_catalog#tags_all-1">AthenaDataCatalog#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type>, value: seq<string * string>) : AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AthenaDataCatalogState<'Description, 'Name, 'Parameters, 'Type>

        member _.Run(state: AthenaDataCatalogState<Present, Present, Present, Present>) : aws.AthenaDataCatalog.AthenaDataCatalog =
            let config = aws.AthenaDataCatalog.AthenaDataCatalogConfig()
            for setter in state.assignments do
                setter config
            aws.AthenaDataCatalog.AthenaDataCatalog(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.athenaDataCatalog: missing required arguments. Must call: description, name, parameters, type.", 9999, IsError = true)>]
        member _.Run(_: AthenaDataCatalogState<_, _, _, _>) : aws.AthenaDataCatalog.AthenaDataCatalog =
            Unchecked.defaultof<aws.AthenaDataCatalog.AthenaDataCatalog>
