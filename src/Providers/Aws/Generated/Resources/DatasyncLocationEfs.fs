namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn> = { assignments: ResizeArray<aws.DatasyncLocationEfs.DatasyncLocationEfsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs">aws_datasync_location_efs</a>.
    /// </summary>
    type DatasyncLocationEfsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationEfsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationEfsState<Missing, Missing>)

        member _.Zero(()) : DatasyncLocationEfsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationEfsState<Missing, Missing>)

        /// <summary>
        /// ec2_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#ec2_config-1">DatasyncLocationEfs#ec2_config</a>
        /// </summary>
        [<CustomOperation "ec2_config">]
        member _.Ec2Config(state: DatasyncLocationEfsState<Missing, 'EfsFileSystemArn>, value: aws.DatasyncLocationEfs.DatasyncLocationEfsEc2Config) : DatasyncLocationEfsState<Present, 'EfsFileSystemArn> =
            state.assignments.Add(fun config -> config.Ec2Config <- value)
            ({ assignments = state.assignments } : DatasyncLocationEfsState<Present, 'EfsFileSystemArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#efs_file_system_arn-1">DatasyncLocationEfs#efs_file_system_arn</a>.
        /// </summary>
        [<CustomOperation "efs_file_system_arn">]
        member _.EfsFileSystemArn(state: DatasyncLocationEfsState<'Ec2Config, Missing>, value: string) : DatasyncLocationEfsState<'Ec2Config, Present> =
            state.assignments.Add(fun config -> config.EfsFileSystemArn <- value)
            ({ assignments = state.assignments } : DatasyncLocationEfsState<'Ec2Config, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#access_point_arn-1">DatasyncLocationEfs#access_point_arn</a>.
        /// </summary>
        [<CustomOperation "access_point_arn">]
        member _.AccessPointArn(state: DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>, value: string) : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn> =
            state.assignments.Add(fun config -> config.AccessPointArn <- value)
            state : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#file_system_access_role_arn-1">DatasyncLocationEfs#file_system_access_role_arn</a>.
        /// </summary>
        [<CustomOperation "file_system_access_role_arn">]
        member _.FileSystemAccessRoleArn(state: DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>, value: string) : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn> =
            state.assignments.Add(fun config -> config.FileSystemAccessRoleArn <- value)
            state : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#id-1">DatasyncLocationEfs#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>, value: string) : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#in_transit_encryption-1">DatasyncLocationEfs#in_transit_encryption</a>.
        /// </summary>
        [<CustomOperation "in_transit_encryption">]
        member _.InTransitEncryption(state: DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>, value: string) : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn> =
            state.assignments.Add(fun config -> config.InTransitEncryption <- value)
            state : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#subdirectory-1">DatasyncLocationEfs#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>, value: string) : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            state : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#tags-1">DatasyncLocationEfs#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>, value: seq<string * string>) : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_efs#tags_all-1">DatasyncLocationEfs#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>, value: seq<string * string>) : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationEfsState<'Ec2Config, 'EfsFileSystemArn>

        member _.Run(state: DatasyncLocationEfsState<Present, Present>) : aws.DatasyncLocationEfs.DatasyncLocationEfs =
            let config = aws.DatasyncLocationEfs.DatasyncLocationEfsConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationEfs.DatasyncLocationEfs(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationEfs: missing required arguments. Must call: ec2_config, efs_file_system_arn.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationEfsState<_, _>) : aws.DatasyncLocationEfs.DatasyncLocationEfs =
            Unchecked.defaultof<aws.DatasyncLocationEfs.DatasyncLocationEfs>
