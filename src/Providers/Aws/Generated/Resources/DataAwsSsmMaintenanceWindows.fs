namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmMaintenanceWindowsState = { assignments: ResizeArray<aws.DataAwsSsmMaintenanceWindows.DataAwsSsmMaintenanceWindowsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows">aws_ssm_maintenance_windows</a>.
    /// </summary>
    type DataAwsSsmMaintenanceWindowsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmMaintenanceWindowsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSsmMaintenanceWindowsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows#filter-1">DataAwsSsmMaintenanceWindows#filter</a> Accepts: aws.IResolvable | aws.DataAwsSsmMaintenanceWindows.DataAwsSsmMaintenanceWindowsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsSsmMaintenanceWindowsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsmMaintenanceWindowsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsSsmMaintenanceWindowsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows#id-1">DataAwsSsmMaintenanceWindows#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmMaintenanceWindowsState, value: string) : DataAwsSsmMaintenanceWindowsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmMaintenanceWindowsState

        member _.Run(state: DataAwsSsmMaintenanceWindowsState) : aws.DataAwsSsmMaintenanceWindows.DataAwsSsmMaintenanceWindows =
            let config = aws.DataAwsSsmMaintenanceWindows.DataAwsSsmMaintenanceWindowsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmMaintenanceWindows.DataAwsSsmMaintenanceWindows(StackContext.get (), logicalId, config)
