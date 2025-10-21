namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmResourceDataSyncState<'Name, 'S3Destination> = { assignments: ResizeArray<aws.SsmResourceDataSync.SsmResourceDataSyncConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_resource_data_sync">aws_ssm_resource_data_sync</a>.
    /// </summary>
    type SsmResourceDataSyncBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmResourceDataSyncState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmResourceDataSyncState<Missing, Missing>)

        member _.Zero(()) : SsmResourceDataSyncState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmResourceDataSyncState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_resource_data_sync#name-1">SsmResourceDataSync#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmResourceDataSyncState<Missing, 'S3Destination>, value: string) : SsmResourceDataSyncState<Present, 'S3Destination> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmResourceDataSyncState<Present, 'S3Destination>)

        /// <summary>
        /// s3_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_resource_data_sync#s3_destination-1">SsmResourceDataSync#s3_destination</a>
        /// </summary>
        [<CustomOperation "s3_destination">]
        member _.S3Destination(state: SsmResourceDataSyncState<'Name, Missing>, value: aws.SsmResourceDataSync.SsmResourceDataSyncS3Destination) : SsmResourceDataSyncState<'Name, Present> =
            state.assignments.Add(fun config -> config.S3Destination <- value)
            ({ assignments = state.assignments } : SsmResourceDataSyncState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_resource_data_sync#id-1">SsmResourceDataSync#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmResourceDataSyncState<'Name, 'S3Destination>, value: string) : SsmResourceDataSyncState<'Name, 'S3Destination> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmResourceDataSyncState<'Name, 'S3Destination>

        member _.Run(state: SsmResourceDataSyncState<Present, Present>) : aws.SsmResourceDataSync.SsmResourceDataSync =
            let config = aws.SsmResourceDataSync.SsmResourceDataSyncConfig()
            for setter in state.assignments do
                setter config
            aws.SsmResourceDataSync.SsmResourceDataSync(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmResourceDataSync: missing required arguments. Must call: name, s3_destination.", 9999, IsError = true)>]
        member _.Run(_: SsmResourceDataSyncState<_, _>) : aws.SsmResourceDataSync.SsmResourceDataSync =
            Unchecked.defaultof<aws.SsmResourceDataSync.SsmResourceDataSync>
