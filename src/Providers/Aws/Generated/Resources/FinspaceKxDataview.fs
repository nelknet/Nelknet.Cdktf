namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> = { assignments: ResizeArray<aws.FinspaceKxDataview.FinspaceKxDataviewConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview">aws_finspace_kx_dataview</a>.
    /// </summary>
    type FinspaceKxDataviewBuilder(logicalId: string) =
        member _.Yield(_: unit) : FinspaceKxDataviewState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxDataviewState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FinspaceKxDataviewState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxDataviewState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#auto_update-1">FinspaceKxDataview#auto_update</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_update">]
        member _.AutoUpdate(state: FinspaceKxDataviewState<Missing, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: bool) : FinspaceKxDataviewState<Present, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.AutoUpdate <- value)
            ({ assignments = state.assignments } : FinspaceKxDataviewState<Present, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#auto_update-1">FinspaceKxDataview#auto_update</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_update">]
        member _.AutoUpdate(state: FinspaceKxDataviewState<Missing, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : FinspaceKxDataviewState<Present, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.AutoUpdate <- value)
            ({ assignments = state.assignments } : FinspaceKxDataviewState<Present, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#az_mode-1">FinspaceKxDataview#az_mode</a>.
        /// </summary>
        [<CustomOperation "az_mode">]
        member _.AzMode(state: FinspaceKxDataviewState<'AutoUpdate, Missing, 'DatabaseName, 'EnvironmentId, 'Name>, value: string) : FinspaceKxDataviewState<'AutoUpdate, Present, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.AzMode <- value)
            ({ assignments = state.assignments } : FinspaceKxDataviewState<'AutoUpdate, Present, 'DatabaseName, 'EnvironmentId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#database_name-1">FinspaceKxDataview#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, Missing, 'EnvironmentId, 'Name>, value: string) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, Present, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, Present, 'EnvironmentId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#environment_id-1">FinspaceKxDataview#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, Missing, 'Name>, value: string) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, Present, 'Name> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#name-1">FinspaceKxDataview#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, Missing>, value: string) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#availability_zone_id-1">FinspaceKxDataview#availability_zone_id</a>.
        /// </summary>
        [<CustomOperation "availability_zone_id">]
        member _.AvailabilityZoneId(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: string) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.AvailabilityZoneId <- value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#changeset_id-1">FinspaceKxDataview#changeset_id</a>.
        /// </summary>
        [<CustomOperation "changeset_id">]
        member _.ChangesetId(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: string) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.ChangesetId <- value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#description-1">FinspaceKxDataview#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: string) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#id-1">FinspaceKxDataview#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: string) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#read_write-1">FinspaceKxDataview#read_write</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_write">]
        member _.ReadWrite(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: bool) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.ReadWrite <- value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#read_write-1">FinspaceKxDataview#read_write</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_write">]
        member _.ReadWrite(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.ReadWrite <- value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// segment_configurations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#segment_configurations-1">FinspaceKxDataview#segment_configurations</a> Accepts: aws.IResolvable | aws.FinspaceKxDataview.FinspaceKxDataviewSegmentConfigurations[]
        /// </summary>
        [<CustomOperation "segment_configurations">]
        member _.SegmentConfigurations(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.SegmentConfigurations <- value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#tags-1">FinspaceKxDataview#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: seq<string * string>) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#tags_all-1">FinspaceKxDataview#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: seq<string * string>) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#timeouts-1">FinspaceKxDataview#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>, value: aws.FinspaceKxDataview.FinspaceKxDataviewTimeouts) : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FinspaceKxDataviewState<'AutoUpdate, 'AzMode, 'DatabaseName, 'EnvironmentId, 'Name>

        member _.Run(state: FinspaceKxDataviewState<Present, Present, Present, Present, Present>) : aws.FinspaceKxDataview.FinspaceKxDataview =
            let config = aws.FinspaceKxDataview.FinspaceKxDataviewConfig()
            for setter in state.assignments do
                setter config
            aws.FinspaceKxDataview.FinspaceKxDataview(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.finspaceKxDataview: missing required arguments. Must call: auto_update, az_mode, database_name, environment_id, name.", 9999, IsError = true)>]
        member _.Run(_: FinspaceKxDataviewState<_, _, _, _, _>) : aws.FinspaceKxDataview.FinspaceKxDataview =
            Unchecked.defaultof<aws.FinspaceKxDataview.FinspaceKxDataview>
