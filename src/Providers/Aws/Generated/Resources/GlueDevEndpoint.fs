namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueDevEndpointState<'Name, 'RoleArn> = { assignments: ResizeArray<aws.GlueDevEndpoint.GlueDevEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint">aws_glue_dev_endpoint</a>.
    /// </summary>
    type GlueDevEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueDevEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueDevEndpointState<Missing, Missing>)

        member _.Zero(()) : GlueDevEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueDevEndpointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#name-1">GlueDevEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueDevEndpointState<Missing, 'RoleArn>, value: string) : GlueDevEndpointState<Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueDevEndpointState<Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#role_arn-1">GlueDevEndpoint#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: GlueDevEndpointState<'Name, Missing>, value: string) : GlueDevEndpointState<'Name, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : GlueDevEndpointState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#arguments-1">GlueDevEndpoint#arguments</a>.
        /// </summary>
        [<CustomOperation "arguments">]
        member _.Arguments(state: GlueDevEndpointState<'Name, 'RoleArn>, value: seq<string * string>) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Arguments <- dict value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#extra_jars_s3_path-1">GlueDevEndpoint#extra_jars_s3_path</a>.
        /// </summary>
        [<CustomOperation "extra_jars_s3_path">]
        member _.ExtraJarsS3Path(state: GlueDevEndpointState<'Name, 'RoleArn>, value: string) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.ExtraJarsS3Path <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#extra_python_libs_s3_path-1">GlueDevEndpoint#extra_python_libs_s3_path</a>.
        /// </summary>
        [<CustomOperation "extra_python_libs_s3_path">]
        member _.ExtraPythonLibsS3Path(state: GlueDevEndpointState<'Name, 'RoleArn>, value: string) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.ExtraPythonLibsS3Path <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#glue_version-1">GlueDevEndpoint#glue_version</a>.
        /// </summary>
        [<CustomOperation "glue_version">]
        member _.GlueVersion(state: GlueDevEndpointState<'Name, 'RoleArn>, value: string) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.GlueVersion <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#id-1">GlueDevEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueDevEndpointState<'Name, 'RoleArn>, value: string) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#number_of_nodes-1">GlueDevEndpoint#number_of_nodes</a>.
        /// </summary>
        [<CustomOperation "number_of_nodes">]
        member _.NumberOfNodes(state: GlueDevEndpointState<'Name, 'RoleArn>, value: double) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.NumberOfNodes <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#number_of_workers-1">GlueDevEndpoint#number_of_workers</a>.
        /// </summary>
        [<CustomOperation "number_of_workers">]
        member _.NumberOfWorkers(state: GlueDevEndpointState<'Name, 'RoleArn>, value: double) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.NumberOfWorkers <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#public_key-1">GlueDevEndpoint#public_key</a>.
        /// </summary>
        [<CustomOperation "public_key">]
        member _.PublicKey(state: GlueDevEndpointState<'Name, 'RoleArn>, value: string) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.PublicKey <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#public_keys-1">GlueDevEndpoint#public_keys</a>.
        /// </summary>
        [<CustomOperation "public_keys">]
        member _.PublicKeys(state: GlueDevEndpointState<'Name, 'RoleArn>, value: seq<string>) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.PublicKeys <- (value |> Seq.toArray))
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#security_configuration-1">GlueDevEndpoint#security_configuration</a>.
        /// </summary>
        [<CustomOperation "security_configuration">]
        member _.SecurityConfiguration(state: GlueDevEndpointState<'Name, 'RoleArn>, value: string) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.SecurityConfiguration <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#security_group_ids-1">GlueDevEndpoint#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: GlueDevEndpointState<'Name, 'RoleArn>, value: seq<string>) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#subnet_id-1">GlueDevEndpoint#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: GlueDevEndpointState<'Name, 'RoleArn>, value: string) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#tags-1">GlueDevEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueDevEndpointState<'Name, 'RoleArn>, value: seq<string * string>) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#tags_all-1">GlueDevEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueDevEndpointState<'Name, 'RoleArn>, value: seq<string * string>) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_dev_endpoint#worker_type-1">GlueDevEndpoint#worker_type</a>.
        /// </summary>
        [<CustomOperation "worker_type">]
        member _.WorkerType(state: GlueDevEndpointState<'Name, 'RoleArn>, value: string) : GlueDevEndpointState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.WorkerType <- value)
            state : GlueDevEndpointState<'Name, 'RoleArn>

        member _.Run(state: GlueDevEndpointState<Present, Present>) : aws.GlueDevEndpoint.GlueDevEndpoint =
            let config = aws.GlueDevEndpoint.GlueDevEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.GlueDevEndpoint.GlueDevEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueDevEndpoint: missing required arguments. Must call: name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: GlueDevEndpointState<_, _>) : aws.GlueDevEndpoint.GlueDevEndpoint =
            Unchecked.defaultof<aws.GlueDevEndpoint.GlueDevEndpoint>
