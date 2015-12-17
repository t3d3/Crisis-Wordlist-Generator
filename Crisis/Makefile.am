
EXTRA_DIST =  

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG_X86
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;"
ASSEMBLY = bin/Debug/crisis.exe
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = exe
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug

CRISIS_EXE_MDB_SOURCE=bin/Debug/crisis.exe.mdb
CRISIS_EXE_MDB=$(BUILD_DIR)/crisis.exe.mdb
C5_DLL_SOURCE=../packages/C5.1.0.2.0/lib/net35/C5.dll
PLOSSUM_COMMANDLINE_DLL_SOURCE=../packages/Plossum.CommandLine.0.3.0.14/lib/net35/Plossum\ CommandLine.dll

endif

if ENABLE_RELEASE_X86
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+
ASSEMBLY = bin/Release/crisis.exe
ASSEMBLY_MDB = 
COMPILE_TARGET = exe
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release

CRISIS_EXE_MDB=
C5_DLL_SOURCE=../packages/C5.1.0.2.0/lib/net35/C5.dll
PLOSSUM_COMMANDLINE_DLL_SOURCE=../packages/Plossum.CommandLine.0.3.0.14/lib/net35/Plossum\ CommandLine.dll

endif

AL=al
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(CRISIS_EXE_MDB) \
	$(C5_DLL) \
	$(PLOSSUM_COMMANDLINE_DLL)  

BINARIES = \
	$(CRISIS)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(BINARIES) 

FILES = \
	AssemblyInfo.cs \
	Charset.cs \
	Combination.cs \
	Generate.cs \
	Help.cs \
	Program.cs \
	Command.cs \
	FilesNameDirectory.cs \
	MenuCMD/MenuDisplayCharset.cs \
	MenuCMD/Menu.cs \
	ProgressBar.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	app.desktop \
	MenuCMD \
	crisis.in 

REFERENCES =  \
	System \
	System.Core

DLL_REFERENCES =  \
	../packages/C5.1.0.2.0/lib/net35/C5.dll \
	../packages/Plossum.CommandLine.0.3.0.14/lib/net35/Plossum\ CommandLine.dll

CLEANFILES = $(PROGRAMFILES) $(BINARIES) 

include $(top_srcdir)/Makefile.include

C5_DLL = $(BUILD_DIR)/C5.dll
PLOSSUM_COMMANDLINE_DLL = $(BUILD_DIR)/Plossum\ CommandLine.dll
CRISIS = $(BUILD_DIR)/crisis

$(eval $(call emit-deploy-target,C5_DLL))
$(eval $(call emit-deploy-target,PLOSSUM_COMMANDLINE_DLL))
$(eval $(call emit-deploy-wrapper,CRISIS,crisis,x))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
