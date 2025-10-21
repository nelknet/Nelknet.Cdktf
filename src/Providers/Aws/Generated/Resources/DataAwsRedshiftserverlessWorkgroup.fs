namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftserverlessWorkgroupState<'WorkgroupName> = { assignments: ResizeArray<aws.DataAwsRedshiftserverlessWorkgroup.DataAwsRedshiftserverlessWorkgroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_workgroup">aws_redshiftserverless_workgroup</a>.
    /// </summary>
    type DataAwsRedshiftserverlessWorkgroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftserverlessWorkgroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftserverlessWorkgroupState<Missing>)

        member _.Zero(()) : DataAwsRedshiftserverlessWorkgroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftserverlessWorkgroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_workgroup#workgroup_name-1">DataAwsRedshiftserverlessWorkgroup#workgroup_name</a>.
        /// </summary>
        [<CustomOperation "workgroup_name">]
        member _.WorkgroupName(state: DataAwsRedshiftserverlessWorkgroupState<Missing>, value: string) : DataAwsRedshiftserverlessWorkgroupState<Present> =
            state.assignments.Add(fun config -> config.WorkgroupName <- value)
            ({ assignments = state.assignments } : DataAwsRedshiftserverlessWorkgroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_workgroup#id-1">DataAwsRedshiftserverlessWorkgroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRedshiftserverlessWorkgroupState<'WorkgroupName>, value: string) : DataAwsRedshiftserverlessWorkgroupState<'WorkgroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRedshiftserverlessWorkgroupState<'WorkgroupName>

        member _.Run(state: DataAwsRedshiftserverlessWorkgroupState<Present>) : aws.DataAwsRedshiftserverlessWorkgroup.DataAwsRedshiftserverlessWorkgroup =
            let config = aws.DataAwsRedshiftserverlessWorkgroup.DataAwsRedshiftserverlessWorkgroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftserverlessWorkgroup.DataAwsRedshiftserverlessWorkgroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRedshiftserverlessWorkgroup: missing required arguments. Must call: workgroup_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRedshiftserverlessWorkgroupState<_>) : aws.DataAwsRedshiftserverlessWorkgroup.DataAwsRedshiftserverlessWorkgroup =
            Unchecked.defaultof<aws.DataAwsRedshiftserverlessWorkgroup.DataAwsRedshiftserverlessWorkgroup>
