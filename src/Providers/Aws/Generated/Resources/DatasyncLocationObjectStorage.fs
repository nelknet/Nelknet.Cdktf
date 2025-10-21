namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> = { assignments: ResizeArray<aws.DatasyncLocationObjectStorage.DatasyncLocationObjectStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage">aws_datasync_location_object_storage</a>.
    /// </summary>
    type DatasyncLocationObjectStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationObjectStorageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationObjectStorageState<Missing, Missing, Missing>)

        member _.Zero(()) : DatasyncLocationObjectStorageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationObjectStorageState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#agent_arns-1">DatasyncLocationObjectStorage#agent_arns</a>.
        /// </summary>
        [<CustomOperation "agent_arns">]
        member _.AgentArns(state: DatasyncLocationObjectStorageState<Missing, 'BucketName, 'ServerHostname>, value: seq<string>) : DatasyncLocationObjectStorageState<Present, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.AgentArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatasyncLocationObjectStorageState<Present, 'BucketName, 'ServerHostname>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#bucket_name-1">DatasyncLocationObjectStorage#bucket_name</a>.
        /// </summary>
        [<CustomOperation "bucket_name">]
        member _.BucketName(state: DatasyncLocationObjectStorageState<'AgentArns, Missing, 'ServerHostname>, value: string) : DatasyncLocationObjectStorageState<'AgentArns, Present, 'ServerHostname> =
            state.assignments.Add(fun config -> config.BucketName <- value)
            ({ assignments = state.assignments } : DatasyncLocationObjectStorageState<'AgentArns, Present, 'ServerHostname>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#server_hostname-1">DatasyncLocationObjectStorage#server_hostname</a>.
        /// </summary>
        [<CustomOperation "server_hostname">]
        member _.ServerHostname(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, Missing>, value: string) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, Present> =
            state.assignments.Add(fun config -> config.ServerHostname <- value)
            ({ assignments = state.assignments } : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#access_key-1">DatasyncLocationObjectStorage#access_key</a>.
        /// </summary>
        [<CustomOperation "access_key">]
        member _.AccessKey(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: string) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.AccessKey <- value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#id-1">DatasyncLocationObjectStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: string) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#secret_key-1">DatasyncLocationObjectStorage#secret_key</a>.
        /// </summary>
        [<CustomOperation "secret_key">]
        member _.SecretKey(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: string) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.SecretKey <- value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#server_certificate-1">DatasyncLocationObjectStorage#server_certificate</a>.
        /// </summary>
        [<CustomOperation "server_certificate">]
        member _.ServerCertificate(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: string) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.ServerCertificate <- value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#server_port-1">DatasyncLocationObjectStorage#server_port</a>.
        /// </summary>
        [<CustomOperation "server_port">]
        member _.ServerPort(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: double) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.ServerPort <- value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#server_protocol-1">DatasyncLocationObjectStorage#server_protocol</a>.
        /// </summary>
        [<CustomOperation "server_protocol">]
        member _.ServerProtocol(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: string) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.ServerProtocol <- value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#subdirectory-1">DatasyncLocationObjectStorage#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: string) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#tags-1">DatasyncLocationObjectStorage#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: seq<string * string>) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_object_storage#tags_all-1">DatasyncLocationObjectStorage#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>, value: seq<string * string>) : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationObjectStorageState<'AgentArns, 'BucketName, 'ServerHostname>

        member _.Run(state: DatasyncLocationObjectStorageState<Present, Present, Present>) : aws.DatasyncLocationObjectStorage.DatasyncLocationObjectStorage =
            let config = aws.DatasyncLocationObjectStorage.DatasyncLocationObjectStorageConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationObjectStorage.DatasyncLocationObjectStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationObjectStorage: missing required arguments. Must call: agent_arns, bucket_name, server_hostname.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationObjectStorageState<_, _, _>) : aws.DatasyncLocationObjectStorage.DatasyncLocationObjectStorage =
            Unchecked.defaultof<aws.DatasyncLocationObjectStorage.DatasyncLocationObjectStorage>
