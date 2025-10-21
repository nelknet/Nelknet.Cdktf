namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AthenaNamedQueryState<'Database, 'Name, 'Query> = { assignments: ResizeArray<aws.AthenaNamedQuery.AthenaNamedQueryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_named_query">aws_athena_named_query</a>.
    /// </summary>
    type AthenaNamedQueryBuilder(logicalId: string) =
        member _.Yield(_: unit) : AthenaNamedQueryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AthenaNamedQueryState<Missing, Missing, Missing>)

        member _.Zero(()) : AthenaNamedQueryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AthenaNamedQueryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_named_query#database-1">AthenaNamedQuery#database</a>.
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: AthenaNamedQueryState<Missing, 'Name, 'Query>, value: string) : AthenaNamedQueryState<Present, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.Database <- value)
            ({ assignments = state.assignments } : AthenaNamedQueryState<Present, 'Name, 'Query>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_named_query#name-1">AthenaNamedQuery#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AthenaNamedQueryState<'Database, Missing, 'Query>, value: string) : AthenaNamedQueryState<'Database, Present, 'Query> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AthenaNamedQueryState<'Database, Present, 'Query>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_named_query#query-1">AthenaNamedQuery#query</a>.
        /// </summary>
        [<CustomOperation "query">]
        member _.Query(state: AthenaNamedQueryState<'Database, 'Name, Missing>, value: string) : AthenaNamedQueryState<'Database, 'Name, Present> =
            state.assignments.Add(fun config -> config.Query <- value)
            ({ assignments = state.assignments } : AthenaNamedQueryState<'Database, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_named_query#description-1">AthenaNamedQuery#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AthenaNamedQueryState<'Database, 'Name, 'Query>, value: string) : AthenaNamedQueryState<'Database, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AthenaNamedQueryState<'Database, 'Name, 'Query>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_named_query#id-1">AthenaNamedQuery#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AthenaNamedQueryState<'Database, 'Name, 'Query>, value: string) : AthenaNamedQueryState<'Database, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AthenaNamedQueryState<'Database, 'Name, 'Query>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_named_query#workgroup-1">AthenaNamedQuery#workgroup</a>.
        /// </summary>
        [<CustomOperation "workgroup">]
        member _.Workgroup(state: AthenaNamedQueryState<'Database, 'Name, 'Query>, value: string) : AthenaNamedQueryState<'Database, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.Workgroup <- value)
            state : AthenaNamedQueryState<'Database, 'Name, 'Query>

        member _.Run(state: AthenaNamedQueryState<Present, Present, Present>) : aws.AthenaNamedQuery.AthenaNamedQuery =
            let config = aws.AthenaNamedQuery.AthenaNamedQueryConfig()
            for setter in state.assignments do
                setter config
            aws.AthenaNamedQuery.AthenaNamedQuery(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.athenaNamedQuery: missing required arguments. Must call: database, name, query.", 9999, IsError = true)>]
        member _.Run(_: AthenaNamedQueryState<_, _, _>) : aws.AthenaNamedQuery.AthenaNamedQuery =
            Unchecked.defaultof<aws.AthenaNamedQuery.AthenaNamedQuery>
