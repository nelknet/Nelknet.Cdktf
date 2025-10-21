namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl> = { assignments: ResizeArray<aws.DatasyncLocationAzureBlob.DatasyncLocationAzureBlobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob">aws_datasync_location_azure_blob</a>.
    /// </summary>
    type DatasyncLocationAzureBlobBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationAzureBlobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationAzureBlobState<Missing, Missing, Missing>)

        member _.Zero(()) : DatasyncLocationAzureBlobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationAzureBlobState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#agent_arns-1">DatasyncLocationAzureBlob#agent_arns</a>.
        /// </summary>
        [<CustomOperation "agent_arns">]
        member _.AgentArns(state: DatasyncLocationAzureBlobState<Missing, 'AuthenticationType, 'ContainerUrl>, value: seq<string>) : DatasyncLocationAzureBlobState<Present, 'AuthenticationType, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.AgentArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatasyncLocationAzureBlobState<Present, 'AuthenticationType, 'ContainerUrl>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#authentication_type-1">DatasyncLocationAzureBlob#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: DatasyncLocationAzureBlobState<'AgentArns, Missing, 'ContainerUrl>, value: string) : DatasyncLocationAzureBlobState<'AgentArns, Present, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            ({ assignments = state.assignments } : DatasyncLocationAzureBlobState<'AgentArns, Present, 'ContainerUrl>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#container_url-1">DatasyncLocationAzureBlob#container_url</a>.
        /// </summary>
        [<CustomOperation "container_url">]
        member _.ContainerUrl(state: DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, Missing>, value: string) : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, Present> =
            state.assignments.Add(fun config -> config.ContainerUrl <- value)
            ({ assignments = state.assignments } : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#access_tier-1">DatasyncLocationAzureBlob#access_tier</a>.
        /// </summary>
        [<CustomOperation "access_tier">]
        member _.AccessTier(state: DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>, value: string) : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.AccessTier <- value)
            state : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#blob_type-1">DatasyncLocationAzureBlob#blob_type</a>.
        /// </summary>
        [<CustomOperation "blob_type">]
        member _.BlobType(state: DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>, value: string) : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.BlobType <- value)
            state : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#id-1">DatasyncLocationAzureBlob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>, value: string) : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>

        /// <summary>
        /// sas_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#sas_configuration-1">DatasyncLocationAzureBlob#sas_configuration</a>
        /// </summary>
        [<CustomOperation "sas_configuration">]
        member _.SasConfiguration(state: DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>, value: aws.DatasyncLocationAzureBlob.DatasyncLocationAzureBlobSasConfiguration) : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.SasConfiguration <- value)
            state : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#subdirectory-1">DatasyncLocationAzureBlob#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>, value: string) : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            state : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#tags-1">DatasyncLocationAzureBlob#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>, value: seq<string * string>) : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#tags_all-1">DatasyncLocationAzureBlob#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>, value: seq<string * string>) : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationAzureBlobState<'AgentArns, 'AuthenticationType, 'ContainerUrl>

        member _.Run(state: DatasyncLocationAzureBlobState<Present, Present, Present>) : aws.DatasyncLocationAzureBlob.DatasyncLocationAzureBlob =
            let config = aws.DatasyncLocationAzureBlob.DatasyncLocationAzureBlobConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationAzureBlob.DatasyncLocationAzureBlob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationAzureBlob: missing required arguments. Must call: agent_arns, authentication_type, container_url.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationAzureBlobState<_, _, _>) : aws.DatasyncLocationAzureBlob.DatasyncLocationAzureBlob =
            Unchecked.defaultof<aws.DatasyncLocationAzureBlob.DatasyncLocationAzureBlob>
