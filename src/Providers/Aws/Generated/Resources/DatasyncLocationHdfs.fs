namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationHdfsState<'AgentArns, 'NameNode> = { assignments: ResizeArray<aws.DatasyncLocationHdfs.DatasyncLocationHdfsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs">aws_datasync_location_hdfs</a>.
    /// </summary>
    type DatasyncLocationHdfsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationHdfsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationHdfsState<Missing, Missing>)

        member _.Zero(()) : DatasyncLocationHdfsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationHdfsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#agent_arns-1">DatasyncLocationHdfs#agent_arns</a>.
        /// </summary>
        [<CustomOperation "agent_arns">]
        member _.AgentArns(state: DatasyncLocationHdfsState<Missing, 'NameNode>, value: seq<string>) : DatasyncLocationHdfsState<Present, 'NameNode> =
            state.assignments.Add(fun config -> config.AgentArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatasyncLocationHdfsState<Present, 'NameNode>)

        /// <summary>
        /// name_node block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#name_node-1">DatasyncLocationHdfs#name_node</a> Accepts: aws.IResolvable | aws.DatasyncLocationHdfs.DatasyncLocationHdfsNameNode[]
        /// </summary>
        [<CustomOperation "name_node">]
        member _.NameNode(state: DatasyncLocationHdfsState<'AgentArns, Missing>, value: HashiCorp.Cdktf.IResolvable) : DatasyncLocationHdfsState<'AgentArns, Present> =
            state.assignments.Add(fun config -> config.NameNode <- value)
            ({ assignments = state.assignments } : DatasyncLocationHdfsState<'AgentArns, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#authentication_type-1">DatasyncLocationHdfs#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#block_size-1">DatasyncLocationHdfs#block_size</a>.
        /// </summary>
        [<CustomOperation "block_size">]
        member _.BlockSize(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: double) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.BlockSize <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#id-1">DatasyncLocationHdfs#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#kerberos_keytab-1">DatasyncLocationHdfs#kerberos_keytab</a>.
        /// </summary>
        [<CustomOperation "kerberos_keytab">]
        member _.KerberosKeytab(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.KerberosKeytab <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#kerberos_keytab_base64-1">DatasyncLocationHdfs#kerberos_keytab_base64</a>.
        /// </summary>
        [<CustomOperation "kerberos_keytab_base64">]
        member _.KerberosKeytabBase64(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.KerberosKeytabBase64 <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#kerberos_krb5_conf-1">DatasyncLocationHdfs#kerberos_krb5_conf</a>.
        /// </summary>
        [<CustomOperation "kerberos_krb5_conf">]
        member _.KerberosKrb5Conf(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.KerberosKrb5Conf <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#kerberos_krb5_conf_base64-1">DatasyncLocationHdfs#kerberos_krb5_conf_base64</a>.
        /// </summary>
        [<CustomOperation "kerberos_krb5_conf_base64">]
        member _.KerberosKrb5ConfBase64(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.KerberosKrb5ConfBase64 <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#kerberos_principal-1">DatasyncLocationHdfs#kerberos_principal</a>.
        /// </summary>
        [<CustomOperation "kerberos_principal">]
        member _.KerberosPrincipal(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.KerberosPrincipal <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#kms_key_provider_uri-1">DatasyncLocationHdfs#kms_key_provider_uri</a>.
        /// </summary>
        [<CustomOperation "kms_key_provider_uri">]
        member _.KmsKeyProviderUri(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.KmsKeyProviderUri <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// qop_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#qop_configuration-1">DatasyncLocationHdfs#qop_configuration</a>
        /// </summary>
        [<CustomOperation "qop_configuration">]
        member _.QopConfiguration(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: aws.DatasyncLocationHdfs.DatasyncLocationHdfsQopConfiguration) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.QopConfiguration <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#replication_factor-1">DatasyncLocationHdfs#replication_factor</a>.
        /// </summary>
        [<CustomOperation "replication_factor">]
        member _.ReplicationFactor(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: double) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.ReplicationFactor <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#simple_user-1">DatasyncLocationHdfs#simple_user</a>.
        /// </summary>
        [<CustomOperation "simple_user">]
        member _.SimpleUser(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.SimpleUser <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#subdirectory-1">DatasyncLocationHdfs#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: string) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#tags-1">DatasyncLocationHdfs#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: seq<string * string>) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#tags_all-1">DatasyncLocationHdfs#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationHdfsState<'AgentArns, 'NameNode>, value: seq<string * string>) : DatasyncLocationHdfsState<'AgentArns, 'NameNode> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationHdfsState<'AgentArns, 'NameNode>

        member _.Run(state: DatasyncLocationHdfsState<Present, Present>) : aws.DatasyncLocationHdfs.DatasyncLocationHdfs =
            let config = aws.DatasyncLocationHdfs.DatasyncLocationHdfsConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationHdfs.DatasyncLocationHdfs(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationHdfs: missing required arguments. Must call: agent_arns, name_node.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationHdfsState<_, _>) : aws.DatasyncLocationHdfs.DatasyncLocationHdfs =
            Unchecked.defaultof<aws.DatasyncLocationHdfs.DatasyncLocationHdfs>
