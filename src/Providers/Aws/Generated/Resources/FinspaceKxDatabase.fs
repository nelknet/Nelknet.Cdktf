namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FinspaceKxDatabaseState<'EnvironmentId, 'Name> = { assignments: ResizeArray<aws.FinspaceKxDatabase.FinspaceKxDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_database">aws_finspace_kx_database</a>.
    /// </summary>
    type FinspaceKxDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : FinspaceKxDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxDatabaseState<Missing, Missing>)

        member _.Zero(()) : FinspaceKxDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxDatabaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_database#environment_id-1">FinspaceKxDatabase#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: FinspaceKxDatabaseState<Missing, 'Name>, value: string) : FinspaceKxDatabaseState<Present, 'Name> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : FinspaceKxDatabaseState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_database#name-1">FinspaceKxDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FinspaceKxDatabaseState<'EnvironmentId, Missing>, value: string) : FinspaceKxDatabaseState<'EnvironmentId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FinspaceKxDatabaseState<'EnvironmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_database#description-1">FinspaceKxDatabase#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: FinspaceKxDatabaseState<'EnvironmentId, 'Name>, value: string) : FinspaceKxDatabaseState<'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : FinspaceKxDatabaseState<'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_database#id-1">FinspaceKxDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FinspaceKxDatabaseState<'EnvironmentId, 'Name>, value: string) : FinspaceKxDatabaseState<'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FinspaceKxDatabaseState<'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_database#tags-1">FinspaceKxDatabase#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FinspaceKxDatabaseState<'EnvironmentId, 'Name>, value: seq<string * string>) : FinspaceKxDatabaseState<'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FinspaceKxDatabaseState<'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_database#tags_all-1">FinspaceKxDatabase#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FinspaceKxDatabaseState<'EnvironmentId, 'Name>, value: seq<string * string>) : FinspaceKxDatabaseState<'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FinspaceKxDatabaseState<'EnvironmentId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_database#timeouts-1">FinspaceKxDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FinspaceKxDatabaseState<'EnvironmentId, 'Name>, value: aws.FinspaceKxDatabase.FinspaceKxDatabaseTimeouts) : FinspaceKxDatabaseState<'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FinspaceKxDatabaseState<'EnvironmentId, 'Name>

        member _.Run(state: FinspaceKxDatabaseState<Present, Present>) : aws.FinspaceKxDatabase.FinspaceKxDatabase =
            let config = aws.FinspaceKxDatabase.FinspaceKxDatabaseConfig()
            for setter in state.assignments do
                setter config
            aws.FinspaceKxDatabase.FinspaceKxDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.finspaceKxDatabase: missing required arguments. Must call: environment_id, name.", 9999, IsError = true)>]
        member _.Run(_: FinspaceKxDatabaseState<_, _>) : aws.FinspaceKxDatabase.FinspaceKxDatabase =
            Unchecked.defaultof<aws.FinspaceKxDatabase.FinspaceKxDatabase>
