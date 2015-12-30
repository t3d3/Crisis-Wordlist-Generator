
EXTRA_DIST =  Makefile

# Warning: This is an automatically generated file, do not edit!

srcdir=.
top_srcdir=..

include $(top_srcdir)/config.make

ifeq ($(CONFIG),DEBUG_X86)
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+ -debug "-define:DEBUG;"
ASSEMBLY = bin/Debug/crisis.exe
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = exe
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug

CRISIS_EXE_MDB_SOURCE=bin/Debug/crisis.exe.mdb
CRISIS_EXE_MDB=$(BUILD_DIR)/crisis.exe.mdb
PLOSSUM_COMMANDLINE_DLL_SOURCE=lib/Plossum\ CommandLine.dll
C5_DLL_SOURCE=lib/C5.dll

endif

ifeq ($(CONFIG),RELEASE_X86)
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+
ASSEMBLY = bin/Release/crisis.exe
ASSEMBLY_MDB = 
COMPILE_TARGET = exe
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release

CRISIS_EXE_MDB=
PLOSSUM_COMMANDLINE_DLL_SOURCE=lib/Plossum\ CommandLine.dll
C5_DLL_SOURCE=lib/C5.dll

endif

AL=al
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(CRISIS_EXE_MDB) \
	$(PLOSSUM_COMMANDLINE_DLL) \
	$(C5_DLL)  

BINARIES = \
	$(CRISIS)  


RESGEN=resgen2

PLOSSUM_COMMANDLINE_DLL = $(BUILD_DIR)/Plossum\ CommandLine.dll
C5_DLL = $(BUILD_DIR)/C5.dll
CRISIS = $(BUILD_DIR)/crisis

FILES = \
	cmd/CommandFunctionCommon.cs \
	cmd/CommandFunctionPattern.cs \
	Tools/Tools.cs \
	AssemblyInfo.cs \
	charset/Charset.cs \
	algo/AlgorithmeFunction.cs \
	algo/Algorithme.cs \
	cmd/CommandFunctionHelp.cs \
	Menu/MainMenu.cs \
	Menu/SubMenu.cs \
	Program.cs \
	cmd/CommandProperty.cs \
	Tools/FilesNameDirectory.cs \
	charset/MenuDisplayCharset.cs \
	Menu/Parameter.cs \
	Tools/Statistical.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	Properties \
	crisis.in 

REFERENCES =  \
	System \
	System.Core \
	System.Numerics

DLL_REFERENCES =  \
	lib/Plossum\ CommandLine.dll \
	lib/C5.dll

CLEANFILES = $(PROGRAMFILES) $(BINARIES) 

#Targets
all: $(ASSEMBLY) $(PROGRAMFILES) $(BINARIES)  $(top_srcdir)/config.make

include $(top_srcdir)/Makefile.include
#include $(srcdir)/custom-hooks.make



$(eval $(call emit-deploy-target,PLOSSUM_COMMANDLINE_DLL))
$(eval $(call emit-deploy-target,C5_DLL))
$(eval $(call emit-deploy-wrapper,CRISIS,crisis,x))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'


$(ASSEMBLY_MDB): $(ASSEMBLY)
$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	make pre-all-local-hook prefix=$(prefix)
	mkdir -p $(shell dirname $(ASSEMBLY))
	make $(CONFIG)_BeforeBuild
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
	make $(CONFIG)_AfterBuild
	make post-all-local-hook prefix=$(prefix)

install-local: $(ASSEMBLY) $(ASSEMBLY_MDB)
	make pre-install-local-hook prefix=$(prefix)
	make install-satellite-assemblies prefix=$(prefix)
	mkdir -p '$(DESTDIR)$(libdir)/$(PACKAGE)'
	$(call cp,$(ASSEMBLY),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(ASSEMBLY_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(CRISIS_EXE_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(PLOSSUM_COMMANDLINE_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(C5_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	mkdir -p '$(DESTDIR)$(bindir)'
	$(call cp,$(CRISIS),$(DESTDIR)$(bindir))
	make post-install-local-hook prefix=$(prefix)

uninstall-local: $(ASSEMBLY) $(ASSEMBLY_MDB)
	make pre-uninstall-local-hook prefix=$(prefix)
	make uninstall-satellite-assemblies prefix=$(prefix)
	$(call rm,$(ASSEMBLY),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(ASSEMBLY_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(CRISIS_EXE_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(PLOSSUM_COMMANDLINE_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(C5_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(CRISIS),$(DESTDIR)$(bindir))
	make post-uninstall-local-hook prefix=$(prefix)

install: install-local
uninstall: uninstall-local
clean: clean-local

include $(top_srcdir)/rules.make
