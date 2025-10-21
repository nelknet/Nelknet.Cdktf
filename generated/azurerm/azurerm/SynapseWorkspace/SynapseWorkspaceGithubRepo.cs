using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseWorkspace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.synapseWorkspace.SynapseWorkspaceGithubRepo")]
    public class SynapseWorkspaceGithubRepo : azurerm.SynapseWorkspace.ISynapseWorkspaceGithubRepo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#account_name SynapseWorkspace#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#branch_name SynapseWorkspace#branch_name}.</summary>
        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}")]
        public string BranchName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#repository_name SynapseWorkspace#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#root_folder SynapseWorkspace#root_folder}.</summary>
        [JsiiProperty(name: "rootFolder", typeJson: "{\"primitive\":\"string\"}")]
        public string RootFolder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#git_url SynapseWorkspace#git_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gitUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GitUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#last_commit_id SynapseWorkspace#last_commit_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastCommitId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastCommitId
        {
            get;
            set;
        }
    }
}
